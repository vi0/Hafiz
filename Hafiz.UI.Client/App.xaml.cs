using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Hafiz.UI.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var window = new Hafiz.UI.Client.Views.Windows.AppMainWindow(new Hafiz.UI.Client.Views.MainAppView());
            //window.DataContext = new Hafiz.UI.Client.ViewModels.MainViewModel();
            window.Show();
        }

    }
}
