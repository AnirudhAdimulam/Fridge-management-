using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fridge_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var lang = Properties.Settings.Default.language;
            CultureInfo.CurrentCulture = new CultureInfo(lang);
            CultureInfo.CurrentUICulture = new CultureInfo(lang);
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            combx_lang.ItemsSource = new List<string> { "en", "de" };


            Lbx_groceries.ItemsSource = App.groceries;
            new_category.ItemsSource = new List<string> { "Dairy", "Fruit", "Vegetable", "Meat", "Soft drinks", "Others" };
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)

        {
            Tbx_filter.Text = "";
            var grc = new Grocery { productName = "Add Product", expireNo = DateTime.Today, category = "select one" };

            App.groceries.Add(grc);
            Lbx_groceries.SelectedItem = grc;
            Lbx_groceries.ScrollIntoView(grc);
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            Tbx_filter.Text = "";
            var itm2delete = Lbx_groceries.SelectedItem;
            if (itm2delete == null)
            {
                MessageBox.Show("please select item to be deleted", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var Grocery = itm2delete as Grocery;
            var res = MessageBox.Show($"do you really want to delete {Grocery.productName}?", "warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (res == MessageBoxResult.Yes)
            {
                App.groceries.Remove(Grocery);
            }


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            My_storage.writeXML<ObservableCollection<Grocery>>(App.groceries, "grocery.xml");

        }

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            {
                var filter = Tbx_filter.Text.ToLower();


                if (filter == "")
                {
                    Lbx_groceries.ItemsSource = App.groceries;

                    return;
                }
                var lstgroceries = (from x in App.groceries
                                    where x.productName.StartsWith(filter, StringComparison.InvariantCultureIgnoreCase)
                                    select x).Concat(from x in App.groceries
                                                     where x.category.StartsWith(filter, StringComparison.InvariantCultureIgnoreCase)
                                                     select x).ToList();
                var lst = (from s in App.groceries where s.productName.ToLower().Contains(filter) select s).Concat(from s in App.groceries where s.category.ToLower().Contains(filter) select s);
                Lbx_groceries.ItemsSource = lst;
                Lbx_groceries.ItemsSource = lstgroceries.Distinct();

            }

        }
        private int a = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            a++;
            textbox1.Text = a.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a--;
            textbox1.Text = a.ToString();
            if (a <= 0)
            {
                a = 1;
            }
        }

        void myMethod()
        {
            DoubleAnimation da = new DoubleAnimation(130, TimeSpan.FromSeconds(1.2));
            if (panel_menu.Width == 130)
            {
                da.To = 36;
                panel_menu.BeginAnimation(DockPanel.WidthProperty, da);
                //  panel_menu.Width = 38;
            }
            else
            {
                panel_menu.BeginAnimation(DockPanel.WidthProperty, da);
                //  panel_menu.Width = 121;
            }
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var win = new quiz();
            win.Owner = this;
            Visibility = Visibility.Collapsed;
            win.Show();
        }

        private void Btn_takequiz_Click(object sender, RoutedEventArgs e)
        {
            var win = new Takequiz { DataContext = App._question[0] };
            win.Owner = this;
            Visibility = Visibility.Collapsed;
            win.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var win = new cookingvideos();
            win.Owner = this;
            Visibility = Visibility.Collapsed;
            win.Show();


            DoubleAnimation da = new DoubleAnimation(130, TimeSpan.FromSeconds(1.2));
            if (panel_menu.Width == 130)
            {
                da.To = 36;
                panel_menu.BeginAnimation(DockPanel.WidthProperty, da);
                //  panel_menu.Width = 38;
            }

            }

            private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            myMethod();
        }

        private void Lbx_groceries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ListBox).SelectedItem == null)
                stp_ProductDetails.IsEnabled = false;
            else
                stp_ProductDetails.IsEnabled = true;
        }

        private void combx_lang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Properties.Settings.Default.language = (sender as ComboBox).SelectedItem.ToString();
            Properties.Settings.Default.Save();
            MessageBox.Show("restart the App");
        }

        private void btn_increment_Click(object sender, RoutedEventArgs e)
        {
            App.groceries = new ObservableCollection<Grocery>(App.groceries.OrderBy(s => s.expireNo));
            Lbx_groceries.ItemsSource = App.groceries;
        }

        private void btn_decrement_Click(object sender, RoutedEventArgs e)
        {
            App.groceries = new ObservableCollection<Grocery>(App.groceries.OrderByDescending(s => s.expireNo));
            Lbx_groceries.ItemsSource = App.groceries;

        }

        private void suggestiontobuy_Click(object sender, RoutedEventArgs e)
        {
            var win = new shoppinglist();
            win.Owner = this;
            Visibility = Visibility.Collapsed;
            win.Show();

            DoubleAnimation da = new DoubleAnimation(130, TimeSpan.FromSeconds(1.2));
            if (panel_menu.Width == 130)
            {
                da.To = 36;
                panel_menu.BeginAnimation(DockPanel.WidthProperty, da);
                //  panel_menu.Width = 38;

            }
        }
    }
}
