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
    /// Interaction logic for shoppinglist.xaml
    /// </summary>
    public partial class shoppinglist : Window
    {

    
        public shoppinglist()
        {
            InitializeComponent();
         
           
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
              Lbx_shopping_list.ItemsSource = App._manageshoppings;
            Lbx_suggestions.ItemsSource = App._shopping;
      



        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;

            My_storage.writeXML<ObservableCollection<manageShopping>>(App._manageshoppings, "shoppinglist.xml");
         //   My_storage.writeXML<List<shopping>>(App._shopping, "suggesteditems.xml");
        }

        private void btn_Add_to_lst_Click(object sender, RoutedEventArgs e)
        {
           // tbx_sugg.Text 
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            var mnglst = new manageShopping { productname = "Add product" };
            App._manageshoppings.Add(mnglst);
            Lbx_shopping_list.SelectedItem = mnglst;
            Lbx_shopping_list.ScrollIntoView(mnglst);
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            var itmdel = Lbx_shopping_list.SelectedItem;
            if (itmdel == null)
            {
                MessageBox.Show("please select item to be deleted", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var mylist = itmdel as manageShopping;
            var res = MessageBox.Show($"do you really want to delete {mylist.productname}?", "warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res == MessageBoxResult.Yes)
            {
                App._manageshoppings.Remove(mylist);
            }


        }


        private void tbx_flitter_TextChanged(object sender, TextChangedEventArgs e)
        {
           

         var filter = tbx_flitter.Text.ToLower();


            if (filter == "")
            {
                Lbx_suggestions.ItemsSource = App._shopping;

                return;
            }
            var lstsuggestion = (from s in App._shopping
                                 where s.name.StartsWith(filter, StringComparison.InvariantCultureIgnoreCase)
                                 select s).ToList();
            var lst = (from s in App._shopping where s.name.ToLower().Contains(filter) select s);
            Lbx_suggestions.ItemsSource = lst;
            Lbx_suggestions.ItemsSource = lstsuggestion.Distinct(); 

        }

    }
    }

