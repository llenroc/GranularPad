using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granular.Extensions;

namespace GranularPad.ViewModels
{
    public class SnippetsGroupViewModel
    {
        public string Header { get; set; }
        public IEnumerable<SnippetViewModel> Items { get; private set; }

        public SnippetsGroupViewModel(string header, IEnumerable<SnippetViewModel> items)
        {
            this.Header = header;
            this.Items = items;
        }
    }
}
