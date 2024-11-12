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

namespace ushindi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProcessManagement_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProcessManagement());
        }

        private void OutputInput_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InputOutputManagement());
        }

        private void FileDirectory_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FileDirectoryManagement());
        }
    }
}
