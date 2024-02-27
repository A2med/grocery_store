using Gerocery.data;

namespace Gerocery;

public partial class drink : ContentPage
{
	public drink()
	{
		InitializeComponent();
        List<Category2> lst = new List<Category2>();
        lst.Add(new Category2()
        {
            Image = "pessi.jpg",
            salary = 60,
            ItemName = "بيبسي كانز_320مل"

        });


        lst.Add(new Category2()
        {
            Image = "sevin.jpg",
            salary = 70,
            ItemName = "بيبسي كانز_320مل"

        });


        lst.Add(new Category2()
        {
            Image = "firouz.jpg",
            salary = 100,
            ItemName = "بيبسي كانز_320مل"

        });


        lst.Add(new Category2()
        {
            Image = "rani.jpg",
            salary = 90,
            ItemName = "بيبسي كانز_320مل"

        });
        lst.Add(new Category2()
        {
            Image = "mirnda.jpg",
            salary = 80,
            ItemName = "بيبسي كانز_320مل"

        });


        lst.Add(new Category2()
        {
            Image = "rani.jpg",
            salary = 45,
            ItemName = "بيبسي كانز_320مل"

        });

        collview.ItemsSource = lst;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var btn = (Button)sender;

        var item = (Category2)btn.BindingContext;
        //  static_class.lstitems.Add(new Category2()); 


        // static_class.lstitems.Add(item);
        maindata.lstitems.Add(item);

        await Shell.Current.GoToAsync("items/item");

    }
}