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
                new SnippetViewModel("StackPanel", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Panels.StackPanel.xaml"))),
                new SnippetViewModel("Grid", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Panels.Grid.xaml"))),
                new SnippetViewModel("DockPanel", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Panels.DockPanel.xaml"))),
                new SnippetViewModel("WrapPanel", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Panels.WrapPanel.xaml"))),
                new SnippetViewModel("Canvas", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Panels.Canvas.xaml"))),
            });
        }
    }
}
