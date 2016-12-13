using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GranularPad.ViewModels;
using System.Windows;

namespace GranularPad.ViewModelBuilders
{
    public class PanelsSnippetsGroupBuilder : IBuilder<SnippetsGroupViewModel>
    {
        public SnippetsGroupViewModel Build()
        {
            return new SnippetsGroupViewModel("Panels", new []
            {
                new SnippetViewModel("StackPanel", "pack://application:,,,/GranularPad;component/Snippets/Panels.StackPanel.xaml"),
                new SnippetViewModel("Grid", "pack://application:,,,/GranularPad;component/Snippets/Panels.Grid.xaml"),
                new SnippetViewModel("DockPanel", "pack://application:,,,/GranularPad;component/Snippets/Panels.DockPanel.xaml"),
                new SnippetViewModel("WrapPanel", "pack://application:,,,/GranularPad;component/Snippets/Panels.WrapPanel.xaml"),
                new SnippetViewModel("Canvas", "pack://application:,,,/GranularPad;component/Snippets/Panels.Canvas.xaml"),
                new SnippetViewModel("UniformGrid", "pack://application:,,,/GranularPad;component/Snippets/Panels.UniformGrid.xaml"),
            });
        }
    }
}
