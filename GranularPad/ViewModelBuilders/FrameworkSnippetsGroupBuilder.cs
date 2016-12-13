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
                new SnippetViewModel("Resources", "pack://application:,,,/GranularPad;component/Snippets/Framework.Resources.xaml"),
                new SnippetViewModel("Binding Modes", "pack://application:,,,/GranularPad;component/Snippets/Framework.Binding.Modes.xaml"),
                new SnippetViewModel("Binding RelativeSource", "pack://application:,,,/GranularPad;component/Snippets/Framework.Binding.RelativeSource.xaml"),
                new SnippetViewModel("Binding UpdateTrigger", "pack://application:,,,/GranularPad;component/Snippets/Framework.Binding.UpdateSourceTrigger.xaml"),
                new SnippetViewModel("KeyboardNavigation", "pack://application:,,,/GranularPad;component/Snippets/Framework.KeyboardNavigation.xaml"),
                new SnippetViewModel("Transforms", "pack://application:,,,/GranularPad;component/Snippets/Framework.Transforms.xaml"),
            });
        }
    }
}
