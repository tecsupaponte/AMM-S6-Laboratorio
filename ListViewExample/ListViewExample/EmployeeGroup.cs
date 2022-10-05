using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewExample
{
    public class EmployeeGroup : ObservableCollection<Employee>
    {
        public string Name { get; set; }

        public EmployeeGroup(string name) : base()
        {
            Name = name;
        }

        public EmployeeGroup(string name, IEnumerable<Employee> source) : base(source)
        {
            Name = name;
        }
    }
}
