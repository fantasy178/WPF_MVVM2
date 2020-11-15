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
        private List<Person> people_List;
        public List<Person> People_List
        {
            get { return people_List; }
        }

        private ObservableCollection<Person> people_Obs;
        public ObservableCollection<Person> People_Obs
        {
            get { return people_Obs; }
        }

        public DelegateCommand UseListUpdateCmd { get; set; }
        public DelegateCommand UseObsUpdateCmd { get; set; }

        public ViewModel()
        {
            UpdateList();
            UpdateObs();

            UseListUpdateCmd = new DelegateCommand(OnUseListUpdateCmdExecuted, (o) => { return true; });
            UseObsUpdateCmd = new DelegateCommand(OnUseObsUpdateCmdExecuted, (o) => { return true; });
        }

        private void OnUseListUpdateCmdExecuted(object obj)
        {
            UpdateList();
        }

        private int updateListCount = 0;
        private void UpdateList()
        {
            //List<Person> people = new List<Person>();
            //people.Add(new Person() { Name = "A", Age = updateListCount });
            //people.Add(new Person() { Name = "B", Age = updateListCount });
            //this.people_List = people;
            //updateListCount++;

            if (this.people_List == null) this.people_List = new List<Person>();
            this.people_List.Add(new Person() { Name = "A", Age = updateListCount });
            this.people_List.Add(new Person() { Name = "B", Age = updateListCount });
            updateListCount++;
        }

        private void OnUseObsUpdateCmdExecuted(object obj)
        {
            UpdateObs();
        }

        private int updateObsCount = 0;
        private void UpdateObs()
        {
            /*
            ObservableCollection<Person> people = new ObservableCollection<Person>();
            people.Add(new Person() { Name = "a", Age = updateObsCount });
            people.Add(new Person() { Name = "b", Age = updateObsCount });
            this.people_Obs = people;
            updateObsCount++;
            */

            if (this.people_Obs == null) this.people_Obs = new ObservableCollection<Person>();
            this.people_Obs.Add(new Person() { Name = "a", Age = updateObsCount });
            this.people_Obs.Add(new Person() { Name = "b", Age = updateObsCount });
            updateObsCount++;
        }
    }
}
