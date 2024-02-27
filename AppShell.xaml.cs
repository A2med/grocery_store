namespace Gerocery
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("items/item", typeof(shopping));
            Routing.RegisterRoute("itemss/items", typeof(SelectedPage));
            Routing.RegisterRoute("login/items", typeof(Login));
            Routing.RegisterRoute("first/items", typeof(Page1));
            Routing.RegisterRoute("ships/items", typeof(ships));
            Routing.RegisterRoute("drink/items", typeof(drink));

        }
    }
}