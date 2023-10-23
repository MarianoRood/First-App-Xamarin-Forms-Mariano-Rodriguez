using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMariano.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SchoolPage : ContentPage
	{
		public SchoolPage ()
		{
			InitializeComponent ();
		}

        public void OnButtonClicked(object sender, EventArgs args)
        {
			Browser.OpenAsync("https://utt.edu.mx/", BrowserLaunchMode.SystemPreferred);
        }
    }
}