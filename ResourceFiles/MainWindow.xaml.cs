using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TwoWayTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> Personer = new List<Person>();

        Person person = new Person(0, "Svend", "Bendt", 123);
        public MainWindow()
        {
            InitializeComponent();

            Personer.Add(person);
            Personer.Add(new Person(1, "Bein", "Stagge", -987654321));
            Personer.Add(new Person(2, "Turt", "Khorsen", 0));
            Personer.Add(new Person(3, "Gill", "Bates", int.MaxValue));

            contentContro1.DataContext = Personer.FirstOrDefault();

            this.DataContext = Personer;
        }

        private void VisDataBtn_Click(object sender, RoutedEventArgs e)
        {
            string PersonData = person.Fornavn +
                " " +
                person.Efternavn +
                " har en formue på " +
                person.Formue +
                " Kr.";

            MessageBox.Show(PersonData);

        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            person.Formue++;
        }
    }
}
