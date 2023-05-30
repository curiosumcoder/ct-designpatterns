using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wa3
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    /// <summary>
    /// MVVM (Model View ViewModel)
    /// </summary>
    public class PersonViewModel
    {
        public ObservableCollection<Person>? People { get; set; }

        public PersonViewModel()
        {
            People = new ObservableCollection<Person>();
        }
    }
}
