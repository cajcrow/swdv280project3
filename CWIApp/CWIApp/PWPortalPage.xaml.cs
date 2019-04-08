using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CWIApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PWPortalPage : ContentPage
	{
		public PWPortalPage ()
		{
			InitializeComponent ();

            BackgroundColor = Color.Red;
            Content = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = "This is the Paperwork Forms Portal!",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    FontAttributes = FontAttributes.Italic,
                    TextColor = Color.Red
                }
            };

        }


    }
}