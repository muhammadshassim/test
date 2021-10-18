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

namespace ProgTask1New
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nameTB.IsEnabled = false;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {   

            // this button adds the users data into the related fields

            Module module = new Module();
            module.Code = ((codeCB.SelectedItem as ComboBoxItem).Content).ToString();
            module.Name = nameTB.Text;
            module.CreditHours = Convert.ToInt32(creditHoursTB.Text);
            module.WeeklyClassHours = Convert.ToInt32(weeklyHoursTB.Text);
            module.NoOfWeeks = Convert.ToInt32(noOfWeeksTB.Text);
            module.ModuleStartDate = startDateCalender.SelectedDate.Value;

            GlobalData.AllModuleData.Add(module);
            this.Hide();
            DataView form = new DataView();
            form.Show();
        }


        private void codeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item = ((codeCB.SelectedItem as ComboBoxItem).Content).ToString();

            //This code simply populates the module name field as user selects modules via module code from drop down menu

            if (item.Equals("PROG6211"))
            {
                nameTB.Text = "Programming 2A";
            }
            if (item.Equals("SAND6231"))
            {
                nameTB.Text = "System Anlysis & Design";
            }
            if (item.Equals("DATA6211"))
            {
                nameTB.Text = "Database 2A";
            }
            if (item.Equals("INRS7311"))
            {
                nameTB.Text = "Introduction to Research";
            }
            if (item.Equals("APDS7211"))
            {
                nameTB.Text = "Application Development Security";
            }
            if (item.Equals("CLDV6211"))
            {
                nameTB.Text = "Cloud Development 2A";
            }
            if (item.Equals("CLDV6211"))
            {
                nameTB.Text = "Cloud Development 2A";
            }
        }

        private void Exit2_btn_Click(object sender, RoutedEventArgs e)
        {
            // closes the application
            this.Close();
        }
    }
}
