using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WindowsApp.Models;

namespace WindowsApp
{
    public class ApiViewModel : ObservableObject
    {
        private string _apiUrl = "https://jsonplaceholder.typicode.com/posts";
        private readonly ObservableCollection<string> _results = new ObservableCollection<string>();

        public string Url
        {
            get { return _apiUrl; }
            set
            {
                _apiUrl = value;
                RaisePropertyChangedEvent("ApiUrl");
            }
        }

        public ICommand Load
        {
            get { return new Command(LoadDataFromApiUrl); }
        }

        public IEnumerable<string> Results
        {
            get { return _results; }
        }

        // Delegate method definitions
        #region Delegates

        private void LoadDataFromApiUrl()
        {
            if (string.IsNullOrEmpty(Url))
            {
                return;
            }
            ApiModel model = new ApiModel(Url);
            _results.Add("Data Type: " + model.DataType);
            _results.Add("Contents: " + model.DataContent);
        }

        #endregion
    }
}
