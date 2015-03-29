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
                new SnippetViewModel("Popup", EmbeddedResourceLoader.LoadResourceString(@"/GranularPad;component/Snippets/Controls.Popup.xaml")),
            });
        }
    }
}
