using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Management;



namespace ushindi
{
    /// <summary>
    /// Interaction logic for ProcessManagement.xaml
    /// </summary>
    public partial class ProcessManagement : Page
    {
        public ProcessManagement()
        {
            InitializeComponent();
        }

        private void ViewAllProcess_Click(object sender, RoutedEventArgs e)
        {
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                try
                {
                    listView1.Items.Add($"Process Name: {process.ProcessName} - ID: {process.Id}");
                }
                catch (Exception ex)
                { 
                    listView1.Items.Add(ex.Message);

                }
            }
        }

        private void CreateNewProcess_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
                Process.Start("winword.exe"); 
                listView1.Items.Add("Microsoft Word started successfully.");
            } 
            catch (Exception ex) 
            { 
                listView1.Items.Add($"Error: {ex.Message}");
            }

        }

        private void SuspendProcess_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void KillProcess_Click(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(textBox1.Text);
            foreach (System.Diagnostics.Process p in Process.GetProcesses())
            {


                if (p.Id == k)
                {
                    p.Kill();
                }
            }

        }

        private void ShutDown_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
                Process.Start("shutdown", "/s /t 0");
                listView1.Items.Add("Shutting down the computer...");
            } 
            catch (Exception ex) 
            { 
                listView1.Items.Add($"Error: {ex.Message}"); 
            }
        }

        private void ListWindowServices_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
