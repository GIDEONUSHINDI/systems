using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for InputOutputManagement.xaml
    /// </summary>
    public partial class InputOutputManagement : Page
    {
        public InputOutputManagement()
        {
            InitializeComponent();
        }

        private void ListFiles_Click(object sender, RoutedEventArgs e)
        {
            listView1.Items.Clear();
            string[] files = Directory.GetFiles("C:\\");
            foreach (string i in files)
            {
                listView1.Items.Add(i);
            }
        }

        private void ListSubFolders_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            listView1.Items.Clear();
            string[] dirs = Directory.GetDirectories("C:\\");
            foreach (string dir in dirs)
            {
                count++;
                listView1.Items.Add(count + " " + dir);

            }
        }

        private void ListDrives_Click(object sender, RoutedEventArgs e)
        {
            listView1.Items.Clear();
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                listView1.Items.Add(drive);
            }
        }

        private void ListFileInformation_Click(object sender, RoutedEventArgs e)
        {
            listView1.Items.Clear();
            string winDir = Environment.GetFolderPath(Environment.SpecialFolder.Windows); 
            FileInfo fileProps = new FileInfo(winDir + "\\notepad.exe");
            listView1.Items.Add("File Name =" +  fileProps.FullName);
            listView1.Items.Add("Creation Time = " + fileProps.CreationTime);
            listView1.Items.Add("Last Access Time = " +fileProps.LastAccessTime);
            listView1.Items.Add("Last Write Time = " + fileProps.LastAccessTime);
            listView1.Items.Add("Size = " + fileProps.Length);
            fileProps = null;
        }

        private void WriteTextFile_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\ADMIN\\Desktop\\ushindi\\text.txt");
            writer.WriteLine("File created using StreamWriter class.");
            writer.Close();
            listView1.Items.Clear();
            listView1.Items.Add("File Witten to text.txt");        
        }

        private void ReadTextFile_Click(object sender, RoutedEventArgs e)
        {
            listView1.Items.Clear();
            StreamReader reader = new StreamReader("C:\\Users\\ADMIN\\Desktop\\ushindi\\text.txt");
            try
            {
                do
                {
                    listView1.Items.Add(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }
            catch
            {
                listView1.Items.Add("File is empty");
            }
            finally
            {
                reader.Close();
            }

        }
    }
}
