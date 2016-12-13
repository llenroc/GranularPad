using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GranularPad.ViewModels;
using System.Windows;

namespace GranularPad.ViewModelBuilders
{
    public class StylesSnippetsGroupBuilder : IBuilder<SnippetsGroupViewModel>
    {
        public SnippetsGroupViewModel Build()
        {
            return new SnippetsGroupViewModel("Styles and Templates", new []
            {
                new SnippetViewModel("DataTemplate", "pack://application:,,,/GranularPad;component/Snippets/Templates.DataTemplate.xaml"),
                new SnippetViewModel("ItemsControl Style", "pack://application:,,,/GranularPad;component/Snippets/Styles.ItemsControl.xaml"),
                new SnippetViewModel("ControlTemplate", "pack://application:,,,/GranularPad;component/Snippets/Templates.ControlTemplate.xaml"),
            });
        }
    }
}
