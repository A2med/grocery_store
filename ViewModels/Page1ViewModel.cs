using Gerocery.data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace Gerocery.ViewModels
{
   public class Page1ViewModel :BaseViewModel
    {
       public Category1 category { get; set; }
        string _name;
        public string name { get => _name;set {
                _name = value;
                onpropertyChange();
            
            } }

        string namew;
        public ICommand select { get; set; }

        public ICommand search { get; set; }

       
     
        ObservableCollection<Category1> _lst;

       
        public ObservableCollection<Category1> lst { get
            {
                return _lst;
            }
                
                set

            {
                _lst = value;
                onpropertyChange();
            }
                
                }




        ObservableCollection<Category1> _lstview;
        public ObservableCollection<Category1> lstview { set { _lstview = value; onpropertyChange(); } get { return _lstview; } }
       

        public Page1ViewModel()
        {
            
            lstview = new ObservableCollection<Category1>();
            lst = new ObservableCollection<Category1>();
            loadData();
            select = new Command(onselect);
            search = new Command(onsearch);
           
            
           

            




        }
        public void loadData()
        {
            
            lst.Add(new Category1()

            {
                imageName = "soma.jpeg"
            }

            );

            lst.Add(new Category1()

            {
                imageName = "pepsi.jpeg"
            }

                );

            lst.Add(new Category1()

            {
                imageName = "oxi.jpeg"
            }

                );
            lstview.Add(new Category1()

            {
                image = "diapers.png",

                name = "ورقيات وحفاضات"
            }

           );
            lstview.Add(new Category1()

            {
                image = "soft.png",

                name = "مشروبات"
            }

                );
            lstview.Add(new Category1()

            {
                image = "canned.png",

                name = "بقالة"
            }



               );

            lstview.Add(new Category1()

            {
                image = "pasta.png",

                name = "مأكولات اساسيه"
            }



               );

            lstview.Add(new Category1()

            {
                image = "shampoo.png",

                name = "عناية شخصية"
            }



              );

            lstview.Add(new Category1()

            {
                image = "snack.png",

                name = "شيبسيات"
            }



             );

            lstview.Add(new Category1()

            {
                image = "food.png",

                name = "جبن والبان"
            }

                );
            lstview.Add(new Category1()

            {
                image = "sweets.png",

                name = "حلويات"
            }

                );
            lstview.Add(new Category1()

            {
                image = "cereal.png",

                name = "سايب"
            }



               );

            lstview.Add(new Category1()

            {
                image = "cards.png",

                name = "كروت شحن"
            }



               );

            lstview.Add(new Category1()

            {
                image = "battery.png",

                name = "بطاريات"
            }



               );

        }

        public async void onselect()
        {
            // SelectedPage oSelectedPage = new SelectedPage();
            //await Navigation.PushAsync(oSelectedPage);

            // Category1 cat1 = new Category1();



            if (category.name == "ورقيات وحفاضات")
            {

                //await Navigation.PushAsync(new SelectedPage());
                await Shell.Current.GoToAsync("itemss/items", new Dictionary<string, object>
                {
                    {"items",this.category }
                }



                   );
            }
            else if (category.name == "شيبسيات")
            {
                await Shell.Current.GoToAsync("ships/items");
                return;
            }

            else if (category.name == "مشروبات")
            {
                await Shell.Current.GoToAsync("drink/items");
                return;
            }

            else
                await Shell.Current.GoToAsync("login/items");
        }

        public void onsearch()
        {

            
           



        }



    }
}
