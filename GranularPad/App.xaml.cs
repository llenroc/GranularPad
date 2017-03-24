using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using GranularPad.ViewModels;
using GranularPad.ViewModelBuilders;

namespace GranularPad
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainViewModel viewModel = new MainViewModelBuilder().Build();

            MainWindow window = new MainWindow();
            window.Content = viewModel;
            window.Show();
        }
    }
}
