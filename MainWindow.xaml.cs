using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _03._11._2023_homework
{
    public class Model { 
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone {  get; set; }
    }


    public class MainViewModel {
        public ObservableCollection<Model> Contacts { get; set; }

        public MainViewModel() {
            Contacts = new ObservableCollection<Model>();
        }

        public void AddContact(string name, string address, string phoneNumber) {
            Contacts.Add(new Model { Name = name, Address = address, Phone = phoneNumber });
        }
    }


    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (DataContext is MainViewModel viewModel) {
                viewModel.AddContact(txtbox_name.Text, txtbox_address.Text, txtbox_phone.Text);
            }
            txtbox_name.Clear();
            txtbox_address.Clear();
            txtbox_phone.Clear();
        }
    }
}
