using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace CWIApp
{
    class InternFormView : INotifyPropertyChanged
    {
        private Stream m_pdfDocumentStream;

        ///
        /// An event to detect the change in the value of a property.
        /// 
        public event PropertyChangedEventHandler PropertyChanged;

        ///
        /// The PDF document stream that is loaded into the instance of the PDF Viewer. 
        /// 
        public Stream PdfDocumentStream
        {
            get => m_pdfDocumentStream;
            set
            {
                m_pdfDocumentStream = value;
                NotifyPropertyChanged("PdfDocumentStream");
            }
        }

        ///
        /// Constructor of the view model class.
        /// 
        public InternFormView()
        {
            //Accessing the PDF document that is added as embedded resource as stream. 
            PdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("CWIApp.Assets.internship_form.pdf");
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
