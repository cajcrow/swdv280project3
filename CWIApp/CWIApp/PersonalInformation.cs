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
        string name, emailAddress, phoneNumber, infoWanted;
        bool wantInfo, firstYear, secondYear, scholarship, credits, structure, enroll;

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
        
         public bool FirstYear
        {
            set { SetProperty(ref firstYear, value); }
            get { return firstYear; }
        }

        public bool SecondYear
        {
            set { SetProperty(ref secondYear, value); }
            get { return secondYear; }
        }

        public bool Scholarship
        {
            set { SetProperty(ref scholarship, value); }
            get { return scholarship; }
        }       

        public bool Credits
        {
            set { SetProperty(ref credits, value); }
            get { return credits; }
        }

        public bool Structure
        {
            set { SetProperty(ref structure, value); }
            get { return structure; }
        }

        public bool Enroll
        {
            set { SetProperty(ref enroll, value); }
            get { return enroll; }
        }

        public string Info
        {
            set { SetProperty(ref infoWanted, value); }
            get { return infoWanted; }
        }
    }
}
