using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WindowsApp.Models;

namespace WindowsApp
{
    public class SchedulerViewModel
    {
        private readonly ObservableCollection<string> _results = new ObservableCollection<string>();

        public ICommand Load
        {
            get { return new Command(LoadDataFromScheduler); }
        }

        public IEnumerable<string> Results
        {
            get { return _results; }
        }

        // Delegate method definitions
        #region Delegates

        private void LoadDataFromScheduler()
        {
            SchedulerModel model = new SchedulerModel();
            _results.Add("Current Scheduled Tasks:");
            _results.Add(model.TaskNames);
        }

        #endregion
    }
}
