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
                new SnippetViewModel("DataTemplate", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Templates.DataTemplate.xaml"))),
                new SnippetViewModel("ItemsControl Style", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Styles.ItemsControl.xaml"))),
                new SnippetViewModel("ControlTemplate", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Templates.ControlTemplate.xaml"))),
            });
        }
    }
}
