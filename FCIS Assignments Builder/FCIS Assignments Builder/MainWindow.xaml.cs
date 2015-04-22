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

namespace FCIS_Assignments_Builder
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

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            COURSE course = new COURSE();
            TAsLogin taLogin = new TAsLogin();

            try
            {
                if (coursesCombobox.SelectedValue.ToString() == "Structure Programming")
                {
                    course = COURSE.STRUCTURE_PROGRAMMING;
                    taLogin.setCourse(course.ToString());
                }
                else
                {
                    course = COURSE.OOP;
                    taLogin.setCourse(course.ToString());
                }

                taLogin.Show();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You must choose a course first!");
            }
        }

        private enum COURSE
        {
            STRUCTURE_PROGRAMMING,
            OOP
        }
    }

    
}
