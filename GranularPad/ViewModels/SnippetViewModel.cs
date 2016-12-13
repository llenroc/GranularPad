using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Granular.Extensions;

namespace GranularPad.ViewModels
{
    public class SnippetViewModel
    {
        public event EventHandler ApplySnippetRequest;

        public string Header { get; private set; }
        public string Content { get; private set; }

        public SnippetViewModel(string header, string absoluteUriString)
        {
            this.Header = header;
            this.Content = Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(Granular.Compatibility.Uri.CreateAbsoluteUri(absoluteUriString)));
        }

        public void ApplySnippet()
        {
            ApplySnippetRequest.Raise(this);
        }
    }
}
