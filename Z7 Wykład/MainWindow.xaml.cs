using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Z7_Wykład
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button kilk");
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Grid kilk");

        }

        private void Canvas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Canvas kilk");
            e.Handled = true;

        }

    }
     public class person : INotifyPropertyChanged
    {
         public string FirstName { get; set; }
         
         public event PropertyChangedEventHandler PropertyChanged;

         private void Notify(string propertyname)
         {
             if (PropertyChanged != null)
             {
                 PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
             }
         }
         private string _firstname;
         public string LasName
         {
             get
             {
                 return _firstname;
             }
             set
             {
                 
                 _firstname = value;
                 Notify("Firstame");
             }
         }
    }
}
