using Gerocery.data;
using Microsoft.Win32.SafeHandles;
using System.Collections.ObjectModel;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace Gerocery;

public partial class Page1 : ContentPage
{
  
    public Page1()
	{
       
       
        InitializeComponent();
		//List<Category1> lst = new List<Category1>();
		//lst.Add(new Category1()

		//{
		//	imageName="soma.jpeg"
		//}

		//	);

  //      lst.Add(new Category1()

  //      {
  //          imageName = "pepsi.jpeg"
  //      }

  //          );

  //      lst.Add(new Category1()

  //      {
  //          imageName = "oxi.jpeg"
  //      }

  //          );
  //      carosal.ItemsSource = lst;

        
  //      lstview.Add(new Category1()

  //      {
  //          image = "diapers.png",

  //          name = "ورقيات وحفاضات"
  //      }

  //          );
  //      lstview.Add(new Category1()

  //      {
  //          image = "soft.png",

  //          name = "مشروبات"
  //      }

  //          );
  //      lstview.Add(new Category1()

  //      {
  //          image = "canned.png",

  //          name = "بقالة"
  //      }



  //         );

  //      lstview.Add(new Category1()

  //      {
  //          image = "pasta.png",

  //          name = "مأكولات اساسيه"
  //      }



  //         );

  //      lstview.Add(new Category1()

  //      {
  //          image = "shampoo.png",

  //          name = "عناية شخصية"
  //      }



  //        );

  //      lstview.Add(new Category1()

  //      {
  //          image = "snack.png",

  //          name = "شيبسيات"
  //      }



  //       );

  //      lstview.Add(new Category1()

  //      {
  //          image = "food.png",

  //          name = "جبن والبان"
  //      }

  //          );
  //      lstview.Add(new Category1()

  //      {
  //          image = "sweets.png",

  //          name = "حلويات"
  //      }

  //          );
  //      lstview.Add(new Category1()

  //      {
  //          image = "cereal.png",

  //          name = "سايب"
  //      }



  //         );

  //      lstview.Add(new Category1()

  //      {
  //          image = "cards.png",

  //          name = "كروت شحن"
  //      }



  //         );

  //      lstview.Add(new Category1()

  //      {
  //          image = "battery.png",

  //          name = "بطاريات"
  //      }



  //         );


  //      colview.ItemsSource = lstview;
    }

    //private void serch_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //  //  lstviewfilter = lstview.Where(a => a.name.Contains(serch.Text)).ToList();
    //    //colview.ItemsSource = lstviewfilter;
        

    //}

    //private async void colview_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //{

    //    var item = e.CurrentSelection.FirstOrDefault() as Category1;
    //    //SelectedPage oSelectedPage = new SelectedPage();
    //    //await Navigation.PushAsync(oSelectedPage);

    //    // Category1 cat1 = new Category1();



    //    if (item.name == "ورقيات وحفاضات")
    //    {
           
    //        //await Navigation.PushAsync(new SelectedPage());
    //        await Shell.Current.GoToAsync("itemss/items", new Dictionary<string, object>()

    //       {
    //           {"items", item }
    //       }
               
               
               
    //           );
          
            
    //    }
            
        








    //    else if(item.name == "شيبسيات")
    //    {
    //        await Navigation.PushAsync(new ships());
    //        return;
    //    }

    //    else if (item.name == "مشروبات")
    //    {
    //        await Navigation.PushAsync(new drink());
    //        return;
    //    }

    //    else 
    //        await Navigation.PushAsync(new Login());





    //}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new shopping());
    }
}