using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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

namespace wa3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var viewModel = new PersonViewModel();

            // Set the DataContext
            this.DataContext = viewModel;

            // Bind the ItemsSource
            lvMain.ItemsSource = viewModel.People;
        }

        private void bAgregar_Click(object sender, RoutedEventArgs e)
        {
            var p = new Person()
            {
                Name = tbNombre.Text,
                Age = Convert.ToInt32(tbEdad.Text)
            };

            var vm = ((PersonViewModel)this.DataContext);
            vm.People?.Add(p);

            MessageBox.Show("Hello World!");
        }
    }
}
