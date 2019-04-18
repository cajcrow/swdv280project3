using System;
using Xamarin.Forms;

namespace CWIApp
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();

            BackgroundColor = Color.White;
            Content = new StackLayout
            {
                Children =
                {
                    new Image { Source = ImageSource.FromResource("CWIApp.Images.Logo.jpg")},
                    new Label {
                    Text = "Welcome to the CWI Software Development App!",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    FontAttributes = FontAttributes.Italic,
                    TextColor = Color.Black,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center},
                    new Label { Text ="Software development is a broad term for the process of creating software tools in a methodical way.This process can include writing code, preparing requirements and objectives, documenting, and testing.The Software Development program provides a solid foundation in the development of client and server - side applications using .NET and open-source technologies.A business without a website is rare these days, and every website requires a skilled technician to make it functional.This program emphasizes proven programming principles, critical-thinking skills, and practical experience while preparing students to obtain industry-recognized certifications.",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    TextColor = Color.Black }
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
