using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace WPF_MVVM2
{
    class ViewModel : ViewModelBase
    {
        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public ObservableCollection<Person> People
        {
            get { return people; }
            set
            {
                if(people != value)
                {
                    people = value;
                    OnPropertyChanged("People");
                }
            }
        }

        public DelegateCommand UseListUpdateCmd { get; set; }
        public DelegateCommand UseObsUpdateCmd { get; set; }

        public ViewModel()
        {
            UseListUpdateCmd = new DelegateCommand(OnUseListUpdateCmdExecuted, (o) => { return true; });
            UseObsUpdateCmd = new DelegateCommand(OnUseObsUpdateCmdExecuted, (o) => { return true; });
        }

        private void OnUseListUpdateCmdExecuted(object obj)
        {
            List<Person> person = new List<Person>();
            person.Add(new Person() { Name = "A", Age = 15 });
            person.Add(new Person() { Name = "B", Age = 30 });
            this.People = new ObservableCollection<Person>(person);
        }
        private void OnUseObsUpdateCmdExecuted(object obj)
        {
            ObservableCollection<Person> person = new ObservableCollection<Person>();
            person.Add(new Person() { Name = "C", Age = 15 });
            person.Add(new Person() { Name = "D", Age = 30 });
            this.People = person;
        }
    }
}
