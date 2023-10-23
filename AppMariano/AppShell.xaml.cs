using AppMariano.ViewModels;
using AppMariano.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppMariano
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
            Routing.RegisterRoute(nameof (WelcomePage), typeof(WelcomePage));
            Routing.RegisterRoute(nameof(SchoolPage), typeof(SchoolPage));
            Routing.RegisterRoute(nameof(AboutPage1), typeof(AboutPage1));
        }

    }
}
