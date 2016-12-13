using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GranularPad.ViewModels;
using System.Windows;

namespace GranularPad.ViewModelBuilders
{
    public class ControlsSnippetsGroupBuilder : IBuilder<SnippetsGroupViewModel>
    {
        public SnippetsGroupViewModel Build()
        {
            return new SnippetsGroupViewModel("Controls", new []
            {
                new SnippetViewModel("Buttons", "pack://application:,,,/GranularPad;component/Snippets/Controls.Buttons.xaml"),
                new SnippetViewModel("Expander", "pack://application:,,,/GranularPad;component/Snippets/Controls.Expander.xaml"),
                new SnippetViewModel("Image", "pack://application:,,,/GranularPad;component/Snippets/Controls.Image.xaml"),
                new SnippetViewModel("ListBox", "pack://application:,,,/GranularPad;component/Snippets/Controls.ListBox.xaml"),
                new SnippetViewModel("Popup", "pack://application:,,,/GranularPad;component/Snippets/Controls.Popup.xaml"),
                new SnippetViewModel("ProgressBar", "pack://application:,,,/GranularPad;component/Snippets/Controls.ProgressBar.xaml"),
                new SnippetViewModel("TextBox", "pack://application:,,,/GranularPad;component/Snippets/Controls.TextBox.xaml"),
            });
        }
    }
}
