using System.ComponentModel;

namespace WindowsApp.Models
{
    public class FileModel : INotifyPropertyChanged
    {
        private string _filePath;
        private string _fileContents;

        public string FilePath
        {
            get
            {
                return _filePath;
            }
            set
            {
                _filePath = value;
                RaisePropertyChanged("FilePath");
            }
        }
        
        public string FileContents
        {
            get
            {
                return _fileContents;
            }
            set
            {
                _fileContents = value;
                RaisePropertyChanged("FileContents");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
