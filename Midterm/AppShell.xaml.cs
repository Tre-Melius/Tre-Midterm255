namespace Midterm
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Assassins_Creed_Valhalla", typeof(AssassinsCreedValhalla));
            Routing.RegisterRoute("Dragon_Age_Origins", typeof(Dragon_Age_Origins));
            Routing.RegisterRoute("Resident_Evil_Requiem", typeof(Resident_Evil_Requiem));
            Routing.RegisterRoute("Tales_of_Xillia", typeof(Tales_of_Xillia));
            Routing.RegisterRoute("Cart", typeof(Checkoutpage));
        }
    }
}
