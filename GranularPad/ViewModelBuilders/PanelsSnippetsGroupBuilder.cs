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
                new SnippetViewModel("StackPanel", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Panels.StackPanel.xaml")),
                new SnippetViewModel("GridPanel", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Panels.Grid.xaml")),
                new SnippetViewModel("DockPanel", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Panels.DockPanel.xaml")),
                new SnippetViewModel("WrapPanel", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Panels.WrapPanel.xaml")),
                new SnippetViewModel("Canvas", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Panels.Canvas.xaml")),
            });
        }
    }
}
