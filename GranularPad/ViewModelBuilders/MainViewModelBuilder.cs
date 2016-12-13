using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GranularPad.ViewModels;
using System.Windows;

namespace GranularPad.ViewModelBuilders
{
    public class MainViewModelBuilder : IBuilder<MainViewModel>
    {
        private IEnumerable<IBuilder<SnippetsGroupViewModel>> groupsBuilders;

        public MainViewModelBuilder()
        {
            this.groupsBuilders = new IBuilder<SnippetsGroupViewModel>[]
            {
                new PanelsSnippetsGroupBuilder(),
                new FrameworkSnippetsGroupBuilder(),
                new StylesSnippetsGroupBuilder(),
                new AnimationSnippetsGroupBuilder(),
                new ControlsSnippetsGroupBuilder(),
                new OthersSnippetsGroupBuilder(),
            };
        }

        public MainViewModel Build()
        {
            return new MainViewModel(groupsBuilders.Select(groupBuilder => groupBuilder.Build()).ToArray())
            {
                TextContent = Granular.Compatibility.String.FromByteArray(EmbeddedResourceLoader.LoadResourceData(Granular.Compatibility.Uri.CreateAbsoluteUri("pack://application:,,,/GranularPad;component/Snippets/Default.xaml")))
            };
        }
    }
}
