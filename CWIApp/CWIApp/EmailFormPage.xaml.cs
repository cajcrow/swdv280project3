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
    public partial class EmailFormPage : ContentPage
    {
        public EmailFormPage()
        {

            InitializeComponent();
        }

        void OnSubmitButtonClicked(object sender, EventArgs args)
        {
            PersonalInformation personalInfo = (PersonalInformation)tableView.BindingContext;

            summaryLabel.Text = String.Format(
                "{0} has an email address " +
                "of {1}, and a phone number of {2}, and is {3}" +
                "a programmer.",
                personalInfo.Name, personalInfo.EmailAddress, personalInfo.PhoneNumber,
                personalInfo.WantInfo ? "" : "not ");
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
