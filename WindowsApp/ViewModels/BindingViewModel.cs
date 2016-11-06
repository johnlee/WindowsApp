using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp
{
    class BindingViewModel : ObservableObject
    {
        private string _variable1 = "variable one";
        private string _variable2 = "variable two";
        private string _variable3 = "variable three";

        public string Variable1
        {
            get { return _variable1; }
            set
            {
                _variable1 = Label1 = value;
                RaisePropertyChangedEvent("Variable1");
                RaisePropertyChangedEvent("Label1");

                // Changing var1 changes var3
                Variable3 = _variable1 + _variable2;
            }
        }

        public string Variable2
        {
            get { return _variable2; }
            set
            {
                _variable2 = Label2 = value;
                RaisePropertyChangedEvent("Variable2");
                RaisePropertyChangedEvent("Label2");

                // Changing var1 changes var3
                Variable3 = _variable1 + _variable2;
            }
        }

        public string Variable3
        {
            get { return _variable3; }
            set
            {
                _variable3 = Label3 = value;
                RaisePropertyChangedEvent("Variable3");
                RaisePropertyChangedEvent("Label3");
            }
        }

        public string Label1 { get; set; }

        public string Label2 { get; set; }

        public string Label3 { get; set; }
    }
}
