using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for FileDirectoryManagement.xaml
    /// </summary>
    public partial class FileDirectoryManagement : Page
    {
        public FileDirectoryManagement()
        {
            InitializeComponent();
        }

        private void CreateDirectory_Click(object sender, RoutedEventArgs e)
        {
            string root = @"C:\patwin";
            listView1.Items.Clear();

            // If directory does not exist, create it.  
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
                listView1.Items.Add("Directory created!");
            }
            else
            {
                MessageBox.Show("Directory Exists!!");
            }

        }

        private void SubDirectory_Click(object sender, RoutedEventArgs e)
        {
            string subdir = @"C:\patwin\rent";
            listView1.Items.Clear();

            // If directory does not exist, create it.  
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
                listView1.Items.Add("The subdirectory created successfully!");
            }
            else
            {
                MessageBox.Show("The Directory already exists!!");
            }


        }

        private void DeleteDirectory_Click(object sender, RoutedEventArgs e)
        {
            string subdir = @"C:\patwin\rent";
            listView1.Items.Clear();
            if (Directory.Exists(subdir))
            {
                Directory.Delete(subdir);
                listView1.Items.Add("Directory deleted!");
            }
            else
            {
                MessageBox.Show("Directory does not exists~");
            }

        }

        private void MoveDirectory_Click(object sender, RoutedEventArgs e)
        {
            string sourceDirName = @"C:\patwin";
            string destDirName = @"C:\stud";
            try
            {
                Directory.Move(sourceDirName, destDirName);
                listView1.Items.Add("Directory Moved!!");
            }
            catch (IOException exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void ListFiles_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
