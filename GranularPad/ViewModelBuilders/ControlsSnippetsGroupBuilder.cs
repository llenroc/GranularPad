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
                new SnippetViewModel("Buttons", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Controls.Buttons.xaml"))),
                new SnippetViewModel("Image", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Controls.Image.xaml"))),
                new SnippetViewModel("Popup", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Controls.Popup.xaml"))),
                new SnippetViewModel("ProgressBar", Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(@"/GranularPad;component/Snippets/Controls.ProgressBar.xaml"))),
            });
        }
    }
}
