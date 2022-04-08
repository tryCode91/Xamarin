using AppTest.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http;

namespace AppTest.ViewModel
{
    public class AdressViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
                handler(this, new PropertyChangedEventArgs(property));
        }


     
        private Adress adress  = new Adress();

        public Adress AdressObj 
        {
            get { return adress; }
            set { 
                adress = value;
                NotifyPropertyChanged("AdressObj");
            }
        }


        public async void loadAdress(string sokparameter)
        {


            string url = "https://ipinfo.io/" + sokparameter + "?token=47dac9880b37fa";

            //string url = "https://ipinfo.io/192.157.21.2?token=47dac9880b37fa";



            var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync(url);

            var adress = JsonConvert.DeserializeObject<Adress>(response);

            AdressObj = adress;
            
        }


    }
}

