using Xamarin.Forms;

namespace AppTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        
            BindingContext = App.AdressModel;

           
        }

        private void btnSok_Clicked(object sender, System.EventArgs e)
        {
            App.AdressModel.loadAdress(txt5ok.Text);
        }
    }
}
