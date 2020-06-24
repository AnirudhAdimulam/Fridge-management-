using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for quiz.xaml
    /// </summary>
    public partial class quiz : Window
    {
        public quiz()
        {
            InitializeComponent();
        }

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MyStorage.WriteXml < ObservableCollection<Question>>(App._question, "questions.xml");
            Owner.Visibility = Visibility.Visible;
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Tbx_filter.Text = "";
            var ques = new Question { id = 0, text = "ques text", answers = new List<Answer>() };
            App._question.Add(ques);
            Lbx_questions.SelectedItem = ques;
            Lbx_questions.ScrollIntoView(ques);
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        
            Lbx_questions.ItemsSource = App._question; 
        }

        private void btn_addAnswer_Click(object sender, RoutedEventArgs e)
        {
            var qselected = Lbx_questions.SelectedItem;
            var ans = new Answer { atext = "ans" };
            (qselected as Question).answers.Add(ans);
        }
    }
}
