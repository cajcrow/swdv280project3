using System;
using Xamarin.Forms;

namespace CWIApp
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
            
            Content = new StackLayout
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
                    new Label { Text ="CWI’s Software Development two year program allows students to attain an associate of applied science degree (AAS) and industry-recognized Microsoft Technology Associate (MTA) certifications. Students learn the skills to become a full stack developer.  The curriculum covers client- and server-side technologies, as well as, database design.  Mobile application and Unity game development are included as second year subjects.",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    TextColor = Color.Black,
                    Margin = 30}
                }
            };
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
    }
}
