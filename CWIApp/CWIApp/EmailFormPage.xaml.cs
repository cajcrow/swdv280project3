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
                "of {2}, and a phone number of {3}, and is {4}" +
                "a programmer.",
                personalInfo.EmailAddress, personalInfo.PhoneNumber,
                personalInfo.WantInfo ? "" : "not ");
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
