using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Z8._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonViewModel viewModel = new PersonViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.FirstName = FirstName.Text;
            viewModel.LastName = LastName.Text;
            viewModel.Age = Convert.ToInt32(Age.Text);
        }
    }

        public class PersonViewModel : INotifyPropertyChanged
        {
            private string _firstname;
            private string _lastname;
            private int _age;
            public string FirstName 
            {
                get
                {
                    return _firstname;
                }
                set
                {
                    if(_firstname != value)
                    {
                        _firstname = value;
                        OnPropertyChanged();
                    }
                    
                }
            }
            public string LastName
            {
                get
                {
                    return _lastname;
                }
                set
                {
                    if (_lastname !=value)
                    {
                        _lastname = value;
                        OnPropertyChanged();
                    }
                    
                }
            }
            public int Age
            {
                get
                {
                    return _age;
                }
                set
                {
                    if (_age != value)
                    {
                        _age = value;
                        OnPropertyChanged();
                    }
                    
                }
            }
            
        
            public event PropertyChangedEventHandler PropertyChanged;

            public void OnPropertyChanged([CallerMemberName]string propertyName = "")
            {
                var evt = PropertyChanged;
                if (evt !=null)
                {
                    evt(this, new PropertyChangedEventArgs(propertyName));
                }
            }

        }
       
}
