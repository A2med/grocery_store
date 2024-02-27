

using Gerocery.data;
using Microsoft.Maui.Animations;

using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using Gerocery.ViewModels;


namespace Gerocery;

public partial class SelectedPage : ContentPage
{
    // public  Category2 Items = new Category2();

    SelectPageViewModel _viewModel;
   
   
    public SelectedPage(SelectPageViewModel viewModel)
	{

        _viewModel = viewModel;
        this.BindingContext = _viewModel;
    
    InitializeComponent();
      //  Category1 category = new Category1();
        
        //txt.Text = category.name;
        //img.Source = ImageSource.FromFile(category.image);
    //    List<Category2> lst = new List<Category2>();
      
    //lst.Add(new Category2()
    //    {
    //        Image = "pam.jpg",
    //        salary = 247,
    //        ItemName = "بامبرز مقاس 2 عبوه التوفير 80 حفاضه"

    //    });


    //    lst.Add(new Category2()
    //    {
    //        Image = "pamp.jpg",
    //        salary = 247,
    //        ItemName = "بامبرز مقاس 3 عبوه التوفير 80 حفاضه"

    //    });


    //    lst.Add(new Category2()
    //    {
    //        Image = "images.jpg",
    //        salary = 247,
    //        ItemName = "جود كير مقاس 2 عبوه التوفير 80 حفاضه"

    //    });


    //    lst.Add(new Category2()
    //    {
    //        Image = "good.jpg",
    //        salary = 247,
    //        ItemName = "جود كير مقاس 3 عبوه التوفير 80 حفاضه"

    //    });
    //    lst.Add(new Category2()
    //    {
    //        Image = "pam.jpg",
    //        salary = 247,
    //        ItemName = "بامبرز مقاس 2 عبوه التوفير 80 حفاضه"

    //    });


    //    lst.Add(new Category2()
    //    {
    //        Image = "pamp.jpg",
    //        salary = 247,
    //        ItemName = "بامبرز مقاس 3 عبوه التوفير 80 حفاضه"

    //    });
         

    //collview.ItemsSource = lst;
     
       
      
       







        //var items = (Category2)collview.ItemsSource;


    }





    //}

    //public void category()
    //{
    //    List<Category2> lst = new List<Category2>();
    //    lst.Add(new Category2()
    //    {
    //        Image="pam.jpg",
    //        salary=247,
    //        ItemName="بامبرز مقاس 2 عبوه التوفير 80 حفاضه"

    //    });


    //    lst.Add(new Category2()
    //    {
    //        Image = "pamp.jpg",
    //        salary = 247,
    //        ItemName = "بامبرز مقاس 3 عبوه التوفير 80 حفاضه"

    //    });


    //    lst.Add(new Category2()
    //    {
    //        Image = "images.jpg",
    //        salary = 247,
    //        ItemName = "جود كير مقاس 2 عبوه التوفير 80 حفاضه"

    //    });


    //    lst.Add(new Category2()
    //    {
    //        Image = "good.jpg",
    //        salary = 247,
    //        ItemName = "جود كير مقاس 3 عبوه التوفير 80 حفاضه"

    //    });

    //    collview.ItemsSource = lst;
    //}





    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    var btn = (Button)sender;

    //    var item = (Category2)btn.BindingContext;
    //    //  static_class.lstitems.Add(new Category2()); 


    //    // static_class.lstitems.Add(item);
    //    maindata.lstitems.Add(item);

    //    await Shell.Current.GoToAsync("items/item");

    //    // await Shell.Current.GoToAsync("items/item");

    //}





    //private async void collview_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //{
    //    Category2 item = new Category2();
    //    static_class.lstitems.Add(item);
    //    await Shell.Current.GoToAsync("items/item");
    //}
}