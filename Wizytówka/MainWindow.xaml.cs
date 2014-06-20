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

namespace Wizytówka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Person
            {
                FirstName = "Damian",
                LastName = "Krysta",
                City = "Mnich",
                EMail = "krypton9208@gmail.com",
                Phone = "793074615"
            };
            //this.DataContext = DataContext;
     
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EMail { get; set; }
            public string City { get; set; }
            public string Phone { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Person
            {
                FirstName = "Damian",
                LastName = "Krysta"
            };
            this.DataContext = DataContext;
        }
    }
}
