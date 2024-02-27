using Gerocery.DA;
using Gerocery.data;
using Kotlin.Jvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using static Android.App.LauncherActivity;
using static Android.Content.ClipData;
using static Android.Graphics.ColorSpace;
using static Java.Util.Jar.Attributes;
using Gerocery.Services;

namespace Gerocery.ViewModels
{


    public class SelectPageViewModel : BaseViewModel
    {
        Category2 _Items;
        public Category2 Items { set; get; }
        public ICommand btn { get; set; }
        public ICommand items { get; set; }
        public ICommand SaveOrder { get; set; }
        public OrderData orders { get; set; }
        decimal _price;

        IGeneric<Category2> _categories;
        IGeneric<OrderData> oorder;

        OrderData _order;
        public OrderData currentorder { get=>_order; set { _order = value; { onpropertyChange(); } } }
       


        public decimal price { get => _price; set { _price = value; onpropertyChange(); } }




        ObservableCollection<Category2> _lst;
        public ObservableCollection<Category2> lst { set { _lst = value;onpropertyChange(); } get=>_lst; }

        ObservableCollection<ItemData> _lstItem;
        public ObservableCollection<ItemData> lstItem { set { _lstItem = value; onpropertyChange(); } get => _lstItem; }

        //   public ObservableCollection<categoriapi> lstapi { set; get; }


        public SelectPageViewModel(IGeneric<Category2> categories, IGeneric<OrderData> order)
        {


            lst = new ObservableCollection<Category2>();
            lstItem = new ObservableCollection<ItemData>();
            Items = new Category2();
            orders = new OrderData();
            SaveOrder = new Command(onsave);
            //  items = new Command<Category2>(onitem);
            //  lstapi = new ObservableCollection<categoriapi>();



            currentorder = new OrderData();

            loadData();
            _categories = categories;
            oorder = order;
            
           
          //  btn = new Command(onbtn);
           
         //   Connectivity.ConnectivityChanged += Connectivity_connectivityChange;
           
          


        }
       public async void Connectivity_connectivityChange(object sender,ConnectivityChangedEventArgs e)
        {
            if (e.NetworkAccess == NetworkAccess.Unknown || e.NetworkAccess == NetworkAccess.None)
                return;
            DateTime dtcash = Preferences.Default.Get(constant.DataBaseConstants.UpdateData, DateTime.Now);
            if (dtcash > DateTime.Now)
               await loadDataFromLoacl();
        }
        public async void loadData()
        {
            DateTime dtcash = Preferences.Default.Get(constant.DataBaseConstants.UpdateData, DateTime.Now);
            NetworkAccess accessType = Connectivity.Current.NetworkAccess;
            if (dtcash > DateTime.Now || accessType == NetworkAccess.None)
            {
                //category2Da ocatehory2da = new category2Da();
                //var category = await ocatehory2da.GetCategorysAsync();
                //lst = new ObservableCollection<Category2>(category);
                //if (category.Count == 0)
                    await loadDataFromLoacl();
            }
            else
            {
                await loadDataFromLoacl();

            }

        }

        public async Task loadDataFromLoacl()
        {
            ItemServices OItemServices = new ItemServices();
          var item=await  OItemServices.GetAll();
            lst= new ObservableCollection<Category2>(item);

           
            //lst.Add(new Category2()
            //{
            //    id = 1,
            //    Image = "pam.jpg",
            //    salary = 247,
            //    ItemName = "بامبرز مقاس 2 عبوه التوفير 80 حفاضه",
            //    Qty = 1


            //});


            //lst.Add(new Category2()
            //{
            //    id = 2,
            //    Image = "pamp.jpg",
            //    salary = 250,
            //    ItemName = "بامبرز مقاس 3 عبوه التوفير 80 حفاضه",
            //    Qty = 1

            //});


            //lst.Add(new Category2()
            //{
            //    id = 3,
            //    Image = "images.jpg",
            //    salary = 260,
            //    ItemName = "جود كير مقاس 2 عبوه التوفير 80 حفاضه",
            //    Qty = 1

            //});


            //lst.Add(new Category2()
            //{
            //    id = 4,
            //    Image = "good.jpg",
            //    salary = 247,
            //    ItemName = "جود كير مقاس 3 عبوه التوفير 80 حفاضه",
            //    Qty = 1

            //});
            //lst.Add(new Category2()
            //{
            //    id = 5,
            //    Image = "pam.jpg",
            //    salary = 246,
            //    ItemName = "بامبرز مقاس 2 عبوه التوفير 80 حفاضه",
            //    Qty = 1

            //});


            //lst.Add(new Category2()
            //{
            //    id = 6,
            //    Image = "pamp.jpg",
            //    salary = 247,
            //    ItemName = "بامبرز مقاس 3 عبوه التوفير 80 حفاضه",
            //    Qty = 1

            //});
            Preferences.Default.Get(constant.DataBaseConstants.UpdateData, DateTime.Now);
           // category2Da ocatehory2da = new category2Da();
           //await ocatehory2da.ClearCategoryAsync();
           //await ocatehory2da.BulkInsert(lst.ToList());

        }
        public async void onbtn()
        {


           
                //await Shell.Current.GoToAsync("items/item");
            
        }
        public async void onsave()
        {
            if(currentorder==null )
            {
               await Shell.Current.DisplayAlert("validation", "error", "ok");
                return;
            }
            else
                await Shell.Current.DisplayAlert("saved", "saved", "ok");

            OrderService oorder = new OrderService();
           await oorder.save(currentorder,true);
            currentorder = new OrderData();
        }
        //public async void onitem(Category2 name)
        //{

        //    if (consData.LstItems.Count > 0)
        //    {
        //        var item = consData.LstItems.Where(a => a.id == name.id).FirstOrDefault();
        //        if (item != null)
        //        {
        //            int Qty = item.Qty;
        //            consData.LstItems.Remove(item);
        //            consData.LstItems.Add(new Category2
        //            {
        //                id = name.id,
        //                ItemName = name.ItemName,
        //                Qty = Qty + 1,
        //                Image=name.Image,
        //                salary = name.salary,
        //            });
        //        }
        //        else
        //        {
        //            consData.LstItems.Add(name);
        //        }
        //    }
        //    else
        //    {
        //        consData.LstItems.Add(name);
        //    }

        //    await Shell.Current.GoToAsync("items/item");
            




        //}

           
            

           
           
            

            

            






        }








    }
        





        


    
    
    

