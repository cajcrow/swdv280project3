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
    public partial class ProjectPage : ContentPage
    {
        public ProjectPage()
        {
            InitializeComponent();
            BackgroundColor = Color.Crimson;
            Content = new StackLayout
            {
                Children =
                {
                    new Image { Source = ImageSource.FromResource("CWIApp.Images.Logo.jpg")},
                    new Label {
                        Text = "Coming Soon",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.Black,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center},
                    new Label{
                        Text ="Hand picked student projects from each semester showcasing what they've learned.",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        TextColor = Color.Black,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    }
                }
            };
        }

        void OnToolbarItemEventsClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new EventPage());

        }

        void OnToolbarItemFormsClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new PWPortalPage());

        }

        void OnToolbarItemProjectClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new ProjectPage());

        }

        void OnToolbarItemEmailClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new EmailFormPage());

        }
    }
}
