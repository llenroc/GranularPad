using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granular.Extensions;

namespace GranularPad.ViewModels
{
    public class SnippetViewModel
    {
        public event EventHandler ApplySnippetRequest;

        public string Header { get; private set; }
        public string Content { get; private set; }

        public SnippetViewModel(string header, string content)
        {
            this.Header = header;
            this.Content = content;
        }

        public void ApplySnippet()
        {
            ApplySnippetRequest.Raise(this);
        }
    }
}
