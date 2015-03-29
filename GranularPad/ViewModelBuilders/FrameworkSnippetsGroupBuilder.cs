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
                new SnippetViewModel("Resources", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Framework.Resources.xaml")),
                new SnippetViewModel("Binding Modes", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Framework.Binding.Modes.xaml")),
                new SnippetViewModel("Binding RelativeSource", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Framework.Binding.RelativeSource.xaml")),
                new SnippetViewModel("Binding UpdateTrigger", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Framework.Binding.UpdateSourceTrigger.xaml")),
            });
        }
    }
}
