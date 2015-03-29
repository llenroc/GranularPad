using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using GranularPad.ViewModels;

namespace GranularPad.Views
{
    public partial class SnippetView : UserControl
    {
        public SnippetView()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            ((SnippetViewModel)DataContext).ApplySnippet();
        }
    }
}
