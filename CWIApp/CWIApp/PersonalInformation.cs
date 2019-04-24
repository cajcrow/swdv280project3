using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.FormsBook.Toolkit;
using Xamarin.Forms;

namespace CWIApp
{
    class PersonalInformation : ViewModelBase
    {
        string name, emailAddress, phoneNumber;
        bool wantInfo;

        public string Name
        {
            set { SetProperty(ref name, value); }
            get { return name; }
        }

        public string EmailAddress
        {
            set { SetProperty(ref emailAddress, value); }
            get { return emailAddress; }
        }

        public string PhoneNumber
        {
            set { SetProperty(ref phoneNumber, value); }
            get { return phoneNumber; }
        }

        public bool WantInfo
        {
            set { SetProperty(ref wantInfo, value); }
            get { return wantInfo; }
        }
    }
}