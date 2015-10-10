using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GranularPad.ViewModels;
using System.Windows;

namespace GranularPad.ViewModelBuilders
{
    public class FrameworkSnippetsGroupBuilder : IBuilder<SnippetsGroupViewModel>
    {
        public SnippetsGroupViewModel Build()
        {
            return new SnippetsGroupViewModel("Framework", new[]
            {
                new SnippetViewModel("Resources", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Framework.Resources.xaml"))),
                new SnippetViewModel("Binding Modes", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Framework.Binding.Modes.xaml"))),
                new SnippetViewModel("Binding RelativeSource", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Framework.Binding.RelativeSource.xaml"))),
                new SnippetViewModel("Binding UpdateTrigger", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Framework.Binding.UpdateSourceTrigger.xaml"))),
                new SnippetViewModel("KeyboardNavigation", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Framework.KeyboardNavigation.xaml"))),
            });
        }
    }
}
