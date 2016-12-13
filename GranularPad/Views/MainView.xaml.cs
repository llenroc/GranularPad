using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using GranularPad.ViewModels;
using System.Windows.Threading;
using System.Windows.Markup;
using System.Windows;
using System.Windows.Media.Animation;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Granular.Extensions;

namespace GranularPad.Views
{
    public partial class MainView : UserControl
    {
        private static readonly Regex ErrorPositionRegex = new Regex("line (number )?([0-9]+)(( at)?,? ((column)|(position)) ([0-9]+))?");
        private const int ErrorPositionRowGroupIndex = 2;
        private const int ErrorPositionColumnGroupIndex = 8;

        private MainViewModel mainViewModel;
        private DispatcherTimer textChangedTimer;
        private Point errorPosition;
        private bool isContentPresenterOverlayVisibile;

        public MainView()
        {
            InitializeComponent();

            textChangedTimer = new DispatcherTimer();
            textChangedTimer.Interval = TimeSpan.FromSeconds(2);
            textChangedTimer.Tick += OnTextChangedTimerTick;

            DataContextChanged += (sender, e) =>
            {
                if (mainViewModel != null)
                {
                    mainViewModel.TextContentChanged -= OnTextContentChanged;
                    mainViewModel.ApplySnippetRequest -= OnApplySnippetRequest;
                }

                mainViewModel = (MainViewModel)DataContext;

                if (mainViewModel != null)
                {
                    mainViewModel.TextContentChanged += OnTextContentChanged;
                    mainViewModel.ApplySnippetRequest += OnApplySnippetRequest;

                    CompileText();
                }
            };
        }

        private void OnTextContentChanged(object sender, EventArgs e)
        {
            ShowContentPresenterOverlay();

            textChangedTimer.Stop();
            textChangedTimer.Start();
        }

        private void OnTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (textChangedTimer.IsEnabled)
            {
                textChangedTimer.Stop();
                textChangedTimer.Start();
            }
        }

        private void OnApplySnippetRequest(object sender, EventArgs e)
        {
            textChangedTimer.Stop();
            CompileText();
        }

        private void OnTextChangedTimerTick(object sender, EventArgs e)
        {
            textChangedTimer.Stop();
            CompileText();
        }

        public void CompileText()
        {
            try
            {
                if (mainViewModel.TextContent.IsNullOrWhiteSpace())
                {
                    contentPresenter.Child = null;
                }
                else
                {
                    FrameworkElement child = (FrameworkElement)XamlLoader.Load(XamlParser.Parse(mainViewModel.TextContent));
                    child.DataContext = null;

                    contentPresenter.Child = child;
                }

                HideErrorMessage();
                HideContentPresenterOverlay();
            }
            catch (Exception e)
            {
                errorTextBlock.Text = e.Message;
                errorPosition = ParseErrorPosition(e.Message);
                ShowErrorMessage();
                ShowContentPresenterOverlay();
            }
        }

        private void ShowErrorMessage()
        {
            errorPanel.Visibility = Visibility.Visible;
            errorPanel.UpdateLayout();

            DoubleAnimation heightAnimation = new DoubleAnimation { From = 0, To = errorPanel.ActualHeight, Duration = new Duration(TimeSpan.FromSeconds(0.3)), EasingFunction = new ExponentialEase { EasingMode = EasingMode.EaseIn }, FillBehavior = FillBehavior.Stop };
            errorPanel.BeginAnimation(FrameworkElement.HeightProperty, heightAnimation);

            DoubleAnimation opacityAnimation = new DoubleAnimation { From = 0, To = 1, Duration = new Duration(TimeSpan.FromSeconds(0.3)) };
            errorPanel.BeginAnimation(UIElement.OpacityProperty, opacityAnimation);
        }

        private void HideErrorMessage()
        {
            errorPanel.Visibility = Visibility.Collapsed;
        }

        private void ShowContentPresenterOverlay()
        {
            if (isContentPresenterOverlayVisibile)
            {
                return;
            }

            isContentPresenterOverlayVisibile = true;
            DoubleAnimation opacityAnimation = new DoubleAnimation { To = 1, Duration = new Duration(TimeSpan.FromSeconds(0.3)) };
            contentPresenterOverlay.BeginAnimation(UIElement.OpacityProperty, opacityAnimation);
        }

        private void HideContentPresenterOverlay()
        {
            if (!isContentPresenterOverlayVisibile)
            {
                return;
            }

            isContentPresenterOverlayVisibile = false;
            DoubleAnimation opacityAnimation = new DoubleAnimation { To = 0, Duration = new Duration(TimeSpan.FromSeconds(0.3)) };
            contentPresenterOverlay.BeginAnimation(UIElement.OpacityProperty, opacityAnimation);
        }

        private void OnErrorPanelMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (!errorPosition.IsEmpty)
            {
                textBox.Focus();
                textBox.CaretIndex = textBox.GetCharacterIndexFromLineIndex((int)errorPosition.Y) + (int)errorPosition.X;

                e.Handled = true;
            }
        }

        private static Point ParseErrorPosition(string errorMessage)
        {
            Match match = ErrorPositionRegex.Match(errorMessage.ToLower());

            if (match.Success && match.Groups[ErrorPositionRowGroupIndex].Success)
            {
                return new Point(
                    match.Groups[ErrorPositionColumnGroupIndex].Success ? Int32.Parse(match.Groups[ErrorPositionColumnGroupIndex].Value) - 1 : 0,
                    Int32.Parse(match.Groups[ErrorPositionRowGroupIndex].Value) - 1);
            }

            return Point.Empty;
        }
    }
}
