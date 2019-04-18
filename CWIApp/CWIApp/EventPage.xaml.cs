using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CWIApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventPage : ContentPage
	{
		public EventPage ()
		{
			InitializeComponent ();
		}


        void OnImageTapped(object sender, EventArgs args)
        {
            TappedEventArgs tap = (TappedEventArgs) args;

            webView.Source = tap.Parameter.ToString();
            overlay.IsVisible = true;
            webView.IsVisible = true;
        }

        void OnGoBackClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = false;
            webView.GoBack();    
        }

        //void OnGoForwardClicked(object sender, EventArgs args)
        //{
        //    overlay.IsVisible = false;
        //    webView.GoForward();
        //}

    }//end class
}//end namespace
