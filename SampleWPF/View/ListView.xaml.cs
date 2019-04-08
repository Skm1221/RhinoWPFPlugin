using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace SampleWPF.View
{
    /// <summary>
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView : UserControl
    {
        public ListView()
        {
            InitializeComponent();

            ObservableCollection<User> items = new ObservableCollection<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new User() { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" });
            items.Add(new User() { Name = "Sam Doe", Age = 17, Mail = "sam.doe@gmail.com" });
            items.Add(new User() { Name = "David Doe", Age = 27, Mail = "david.doe@gmail.com" });
            items.Add(new User() { Name = "Tom Doe", Age = 35, Mail = "tom.doe@gmail.com" });
            items.Add(new User() { Name = "Mario Doe", Age = 23, Mail = "mario.doe@gmail.com" });
            items.Add(new User() { Name = "Ramsey Doe", Age = 25, Mail = "ramsey.doe@gmail.com" });
            lvUsers.ItemsSource = items;
        }

        public class User
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Mail { get; set; }
        }
    }
}
