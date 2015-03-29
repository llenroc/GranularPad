using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Granular.Extensions;
using System.ComponentModel;

namespace GranularPad.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler TextContentChanged;
        public event EventHandler ApplySnippetRequest;

        public IEnumerable<SnippetsGroupViewModel> SnippetsGroups { get; private set; }

        private string textContent;
        public string TextContent
        {
            get { return textContent; }
            set
            {
                if (textContent == value)
                {
                    return;
                }

                textContent = value;
                PropertyChanged.Raise(this, "TextContent");
                TextContentChanged.Raise(this);
            }
        }

        public MainViewModel(IEnumerable<SnippetsGroupViewModel> snippetsGroups)
        {
            this.SnippetsGroups = snippetsGroups;

            foreach (SnippetViewModel snippet in snippetsGroups.SelectMany(snippetsGroup => snippetsGroup.Items))
            {
                snippet.ApplySnippetRequest += OnApplySnippetRequest;
            }
        }

        private void OnApplySnippetRequest(object sender, EventArgs e)
        {
            if (TextContent != ((SnippetViewModel)sender).Content)
            {
                TextContent = ((SnippetViewModel)sender).Content;
                ApplySnippetRequest.Raise(this);
            }
        }
    }
}
