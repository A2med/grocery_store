using Gerocery.data;

namespace Gerocery;

public partial class ships : ContentPage
{
	public ships()
	{
		InitializeComponent();
        List<Category2> lst = new List<Category2>();
        lst.Add(new Category2()
        {
            Image = "snack.png",
            salary = 60,
            ItemName = " شيبسي جبنه متبله جامبو ب 5  "

        });


        lst.Add(new Category2()
        {
            Image = "shipss.jpg",
            salary = 70,
            ItemName = "شيبسي جبنه متبله جامبو ب 5"

        });


        lst.Add(new Category2()
        {
            Image = "sh.jpg",
            salary = 100,
            ItemName = "شيبسي جبنه متبله جامبو ب 5"

        });


        lst.Add(new Category2()
        {
            Image = "shipss.jpg",
            salary = 90,
            ItemName = "شيبسي جبنه متبله جامبو ب 5"

        });
        lst.Add(new Category2()
        {
            Image = "ship.jpg",
            salary = 80,
            ItemName = "شيبسي جبنه متبله جامبو ب 5"

        });


        lst.Add(new Category2()
        {
            Image = "sh.jpg",
            salary = 45,
            ItemName = "شيبسي جبنه متبله جامبو ب 5"

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