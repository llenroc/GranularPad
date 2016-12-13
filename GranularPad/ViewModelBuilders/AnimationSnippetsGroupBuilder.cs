using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GranularPad.ViewModels;
using System.Windows;

namespace GranularPad.ViewModelBuilders
{
    public class AnimationSnippetsGroupBuilder : IBuilder<SnippetsGroupViewModel>
    {
        public SnippetsGroupViewModel Build()
        {
            return new SnippetsGroupViewModel("Animations", new[]
            {
                new SnippetViewModel("Easing functions", "pack://application:,,,/GranularPad;component/Snippets/Animation.EasingFunctions.xaml"),
                new SnippetViewModel("UsingKeyFrames", "pack://application:,,,/GranularPad;component/Snippets/Animation.UsingKeyFrames.xaml"),
                new SnippetViewModel("Compose", "pack://application:,,,/GranularPad;component/Snippets/Animation.Compose.xaml"),
                new SnippetViewModel("RepeatForever", "pack://application:,,,/GranularPad;component/Snippets/Animation.RepeatForever.xaml"),
            });
        }
    }
}
