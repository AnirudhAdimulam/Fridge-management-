
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Fridge_Management
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


     //manage shopping list    

      public static ObservableCollection<manageShopping> _manageshoppings;


        //manage suggestion
        public static List<shopping> _shopping;


        //manage fridge
      public static ObservableCollection<Grocery> groceries;
        public static ObservableCollection<Question> _question;

        private void Application_Startup(object sender, StartupEventArgs e)
        {

            //manage suggestion
            _shopping = My_storage.ReadXML<List<shopping>>("suggesteditems.xml");

            if (_shopping == null)
                _shopping = new List<shopping>();



            //manage shopping list

            _manageshoppings = My_storage.ReadXML<ObservableCollection<manageShopping>>("shoppinglist.xml");

            if (_manageshoppings == null)
                _manageshoppings = new ObservableCollection<manageShopping>();

          


            //manage fridge
          //  groceries = new ObservableCollection<Grocery>();
            _question  = MyStorage.ReadXml<ObservableCollection<Question>>("questions.xml");

            groceries = My_storage.ReadXML<ObservableCollection<Grocery>>("grocery.xml");
            if (groceries == null)
                groceries = new ObservableCollection<Grocery>();

        }


        //manage suggestion

  /*      private List<shopping> Generatesuggestionlist(int cnt)
        {
            var lst = new List<shopping>();


            for (int i = 0; i < cnt; i++)
            {
                shopping st = new shopping { name = $"name {i}", imagePath =$"name {i}", benifits = $"benifits{i}" };
                lst.Add(st);
            }

            return lst;
        }  */




        private ObservableCollection<manageShopping> GenerateShoppinglist(int cnt)
        {
            var lst = new ObservableCollection<manageShopping>();


            for (int i = 0; i < cnt; i++)
            {
                manageShopping std = new manageShopping { productname = $"name {i}" };
                lst.Add(std);
            }

            return lst;
        }

       

       

        private ObservableCollection<Grocery> GenerateGroceries(int cnt)
        {
            var list = new ObservableCollection<Grocery>();

            for (int i = 0; i < cnt; i++)
            {
                Grocery grc = new Grocery { productName = $"productName {i}" };
                list.Add(grc);
            }
            return list;
        }
    }
}
