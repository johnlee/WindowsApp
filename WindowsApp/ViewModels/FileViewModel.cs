using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

        public ICommand LoadFile
        {
            get { return new Command(LoadFileIntoResults); }
        }

        public IEnumerable<string> Results
        {
            get { return _results; }
        }

        // Delegate method definitions
        #region Delegates

        private void LoadFileIntoResults()
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                return;
            }
            FileModel model = new FileModel(FilePath);
            _results.Add("Last Modified: " + model.ModifiedDate.ToString());
            _results.Add("Contents: " + model.FileContents);
        }

        #endregion
    }
}
