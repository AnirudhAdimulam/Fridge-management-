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
using System.Windows.Navigation;

namespace Fridge_Management
{
    /// <summary>
    /// Interaction logic for cookingvideos.xaml
    /// </summary>
    public partial class cookingvideos : Window
    {
        public cookingvideos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.Navigate($"https://youtu.be/U0zk2H3mMoA");
            txt_disp.Text = "How to prepare Veg-Lasagna receipe at home"; 

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            webBrowser.Navigate($"https://youtu.be/OPmPHXan1bA ");
            txt_disp.Text = "How to prepare Samosa  ";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            webBrowser.Navigate($"https://youtu.be/oYZ--rdHL6I");
            txt_disp.Text = "How to prepare panner butter masala receipe";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            webBrowser.Navigate($"https://youtu.be/Sm54jrtrnUE");
            txt_disp.Text = "How to prepare chocolate cake at home";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }
    }
}
