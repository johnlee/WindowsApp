﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WindowsApp
{
    class NavigationViewModel : ObservableObject
    {
        private object selectedViewModel;

        public ICommand btnApiView { get; set; }
        public ICommand btnFileView { get; set; }
        public ICommand btnRegistryView { get; set; }
        public ICommand btnSchedulerView { get; set; }
        
        public object SelectedViewModel
        {
            get
            {
                return selectedViewModel;
            }
            set
            {
                selectedViewModel = value;
                RaisePropertyChangedEvent("SelectedViewModel");
            }
        }

        public NavigationViewModel()
        {
            btnFileView = new Command(ShowFileView);
            btnApiView = new Command(ShowAPIView);
            btnRegistryView = new Command(ShowRegistryView);
            btnSchedulerView = new Command(ShowSchedulerView);
        }

        private void ShowFileView()
        {
            SelectedViewModel = new FileViewModel();
        }

        private void ShowAPIView()
        {
            SelectedViewModel = new ApiViewModel();
        }

        private void ShowRegistryView()
        {
            SelectedViewModel = new RegistryViewModel();
        }

        private void ShowSchedulerView()
        {
            SelectedViewModel = new SchedulerViewModel();
        }
    }
}
