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
using System.Windows.Shapes;

namespace ProgTask1New
{
    /// <summary>
    /// Interaction logic for LogHours.xaml
    /// </summary>
    public partial class LogHours : Window
    {
        public LogHours()
        {
            InitializeComponent();
            PreparePopulateComboBox();
        }

        private void PreparePopulateComboBox()
        {
            moduleCB.Items.Clear();
            foreach (Module eachModule in GlobalData.AllModuleData)
            {
                //this code only adds items into the combobox if the user has previously added that item
                ComboBoxItem comboBox_Item = new ComboBoxItem();
                comboBox_Item.Content = eachModule.Code;
                moduleCB.Items.Add(comboBox_Item);
            }
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            //  getting our module ready
            string moduleCode = ((moduleCB.SelectedItem as ComboBoxItem).Content).ToString();

            // using LINQ, I am extractinng the selected module from the combobox
            Module foundModule = GlobalData.AllModuleData.Find(x => x.Code.Equals(moduleCode));
            GlobalData.AllModuleData.Remove(foundModule);

            // getting no. of hours ready
            int hours = Convert.ToInt32(hoursEnteredTB.Text);

            // taking user hour balance and subtracting the studied hours from total required hours
            foundModule.OverallStudyHoursRemaining = foundModule.OverallStudyHoursRemaining - hours;

            // NEW BRICK
            GlobalData.AllModuleData.Add(foundModule);

            // getting date and time ready
            DateTime calender = calenderCAL.SelectedDate.Value;

            Log log = new Log();
            log.ID = moduleCode;
            log.HoursStudied = hours;
            log.LogDateTime = calender;

            // time based list
            foundModule.AllMyLogs.Add(log);

            this.Hide();
            DataView form = new DataView();
            form.Show();

        }

        private void exit3btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
