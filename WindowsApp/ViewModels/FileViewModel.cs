using Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WindowsApp
{
    public class FileViewModel : ObservableObject
    {
        private string _filePath;
        private readonly ObservableCollection<string> _results = new ObservableCollection<string>();

        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                RaisePropertyChangedEvent("FilePath");
            }
        }

        public IEnumerable<string> Results
        {
            get { return _results; }
        }

        public ICommand LoadFile
        {
            get { return new Command(LoadFileIntoResults); }
        }

        // Delegate method definitions
        private void LoadFileIntoResults()
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                return;
            }
            string fileContents = FileReader.GetNonBinaryContents(_filePath);
            DateTime fileModified = FileReader.GetModifiedTime(_filePath);
            _results.Add("File Last Modified: " + fileModified.ToString());
            _results.Add("File Contents: ");
            _results.Add(fileContents);
        }
    }
}
