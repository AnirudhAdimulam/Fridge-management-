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

namespace Fridge_Management
{
    /// <summary>
    /// Interaction logic for Takequiz.xaml
    /// </summary>
    public partial class Takequiz : Window
    {
        public Takequiz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sel = lbx_answers.SelectedItem;

            if(sel == null)
            {
                MessageBox.Show("select answer");
                return;
            }

            if ((sel as Answer).isCorrect)
                MessageBox.Show("correct");
            else
                MessageBox.Show("wrong");
        }
    }
}
