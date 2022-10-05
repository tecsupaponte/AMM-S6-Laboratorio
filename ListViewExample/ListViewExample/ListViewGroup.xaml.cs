using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ListViewGroup()
        {
            InitializeComponent();

            EmployeeList.Add(new EmployeeGroup("Grupo A", new[] { new Employee
            {
                DisplayName = "Alejandro"
            }, new Employee
            {
                DisplayName = "Hugo"
            }}));
            EmployeeList.Add(new EmployeeGroup("Grupo B", new[] { new Employee
            {
                DisplayName = "Alfonso"
            }, new Employee
            {
                DisplayName = "Javier"
            }}));
            EmployeeList.Add(new EmployeeGroup("Grupo C", new[] { new Employee
            {
                DisplayName = "Maria"
            }, new Employee
            {
                DisplayName = "Augusto"
            }, new Employee
            {
                DisplayName = "Claudio"
            }}));

            lstView.ItemsSource = EmployeeList;
        }

        public ObservableCollection<EmployeeGroup> EmployeeList { get; set; } = new ObservableCollection<EmployeeGroup>();
    }
}