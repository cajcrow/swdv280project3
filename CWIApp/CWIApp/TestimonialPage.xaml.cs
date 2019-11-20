using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CWIApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestimonialPage : ContentPage
    {
        public TestimonialPage()
        {
            InitializeComponent();

            var stackContent = new StackLayout
            {
                Children =
                {
                    /*Create and style Top Image*/
                    new Image { Source = ImageSource.FromResource("CWIApp.Images.Logo.jpg"),
                    Margin = 30},
                    /*Create and style Body Title text*/
                    new Label {
                    Text = "Welcome to the CWI Software Development App!",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    FontAttributes = FontAttributes.Italic,
                    TextColor = Color.Black,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Margin = 30},
                                      /*Create and style Body text*/
                    new Label { Text ="I currently have interns helping out. They are bright, energetic and have received valuable instruction to date. They have become an indispensable part of the IT program at CFK. -Michael Swenson",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    TextColor = Color.Black,
                    Margin = 20},

                    new Label { Text ="We would like the interns, CWI, and our company to create and design a portal for the internship program. -Bruce Sanders",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    TextColor = Color.Black,
                    Margin = 20},
                    new Label { Text ="I made a program that shows the dire consequences of using a program to make fun of your teacher, use it for funny results - A Prankster",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    TextColor = Color.Black,
                    Margin = 30}
                }
            };
            Content = new ScrollView { Content = stackContent };
        }

        void OnToolbarItemHomeClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new LandingPage());

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
        void OnToolbarItemTestimonalClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new TestimonialPage());

        }
    }
}
