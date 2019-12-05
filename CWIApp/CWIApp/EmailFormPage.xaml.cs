using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                //adding regex for field requirements
                bool isPhonePattern(string phoneNumber)
            {
                Regex phonePattern = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
                return !phonePattern.IsMatch(phoneNumber);
            }
            bool isEmailPattern(string emailAddress)
            {
                Regex emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                return !emailPattern.IsMatch(emailAddress);
            }

            //return of phone 
            bool isPhoneNotValid = isPhonePattern(personalInfo.PhoneNumber);
            bool isEmailNotValid = isEmailPattern(personalInfo.EmailAddress);

            //adding field requirements for name, email and phone number
            if (personalInfo.Name == String.Empty || personalInfo.Name == null)
            {
                summaryLabel.Text = String.Format(
                    "Please enter your name.");
            }
            else if ((personalInfo.EmailAddress == String.Empty || personalInfo.EmailAddress == null) && isEmailNotValid == true)
            {
                summaryLabel.Text = String.Format(
                    "Please enter a valid Email.");
            }
            else if((personalInfo.PhoneNumber == String.Empty || personalInfo.PhoneNumber == null) && isPhoneNotValid == true)
            {
                summaryLabel.Text = String.Format(
                    "Please enter a valid phone number.");
            }
            else
            {
                summaryLabel.Text = String.Format(
                    "{0} has an email address " +
                    "of {1}, and a phone number of {2}, and is {3}" +
                    "a programmer.",
                    personalInfo.Name, personalInfo.EmailAddress, personalInfo.PhoneNumber,
                    personalInfo.WantInfo ? "" : "not ");
            }
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
