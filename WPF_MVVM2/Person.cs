using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace WPF_MVVM2
{
    class Person : ViewModelBase
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if(name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if(age != value)
                {
                    age = value;
                    OnPropertyChanged("Age");
                }
            }
        }
    }
}
