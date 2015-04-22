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

namespace FCIS_Assignments_Builder
{
    /// <summary>
    /// Interaction logic for TAsLogin.xaml
    /// </summary>
    public partial class TAsLogin : Window
    {
        private string course;

        public TAsLogin()
        {
            InitializeComponent();
        }

        public void setCourse(string course)
        {
            this.course = course;
        }
    }
}
