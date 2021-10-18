using FormulaLibrary;
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
    /// Interaction logic for DataView.xaml
    /// </summary>
    public partial class DataView : Window
    {
        public DataView()
        {
            List<string> moduleIDholder = new List<string>();

            InitializeComponent();

            foreach (Module x in GlobalData.AllModuleData)
            {
                moduleIDholder.Add(x.Code);
            }
            
            moduleDataListView.ItemsSource = moduleIDholder;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow form = new MainWindow();
            form.Show();
        }

        private void moduleDataListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // a specific module code is assigned to 'moduleCode' based on the user click
            string moduleCode = moduleDataListView.SelectedItem.ToString();

            //empty list
            List<Log> allLogs = new List<Log>();

            // we are running a FOREACH loop through ALL modules in the 'AllModuleData' list
            foreach (Module i in GlobalData.AllModuleData) //PROG
            {
                if (i.AllMyLogs == null) 
                { 
                    //DO NOTHING!
                } 
                else
                {
                    foreach (Log j in i.AllMyLogs) // this is looking for any iteration of 'i' which can be any module, it then adds each iteration pertaining to that module into 'j' 
                    {
                        if (j.ID.Equals(moduleCode)) //once 'j' has been found, it is added into the 'allLogs' list
                        {
                            allLogs.Add(j);
                        }
                    }
                }
            }

            logListView.ItemsSource = allLogs;


            // based on the selected 'moduleCode', we extract the relevant 'Module' from the main array (AllModuleData)
            Module foundModule = GlobalData.AllModuleData.Find(x => x.Code.Equals(moduleCode));            

            if (foundModule.TotalAlreadyCalculated == false)
            {
                Console.WriteLine("THIS STATEMENT RAN");
                int value = Formula.CalculateTotalStudyHours(foundModule.CreditHours, foundModule.NoOfWeeks, foundModule.WeeklyClassHours);
                //this is for record and storage purpose (for balance purpose)
                foundModule.OverallStudyHoursRemaining = value;
            }

            foundModule.TotalAlreadyCalculated = true;

            //displaying purposes
            totalHoursLBL.Content = foundModule.OverallStudyHoursRemaining;
            weeklyHoursLBL.Content = foundModule.OverallStudyHoursRemaining / foundModule.NoOfWeeks;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LogHours form = new LogHours();
            form.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
