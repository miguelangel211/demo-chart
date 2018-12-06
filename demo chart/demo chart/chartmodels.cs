using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using Syncfusion;
namespace demo_chart
{
    public class ViewModel
    {
        public ObservableCollection<Model> Concluidos { get; set; }

        public ObservableCollection<Model> Proceso { get; set; }
        public ObservableCollection<Model> Delays { get; set; }

        public ViewModel()
        {
            Concluidos = new ObservableCollection<Model>();
                Proceso = new ObservableCollection<Model>();
            Delays = new ObservableCollection<Model>();
            call(JsonConvert.SerializeObject(new fecha { Fecha= "2017-09-29" }));
            
        }


        public void call(string fecha) {


            var client = new RestClient("http://webaccess.ddns.net:8011/DSOAPI");
            var request = new RestRequest("api/Embarques/Embarquesporhora", Method.POST);

            try
            {



                request.AddJsonBody(fecha);
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
               var d= JsonConvert.DeserializeObject<List<datos>>(response.Content);
                foreach (var h in d) {
                    Concluidos.Add(new Model(h.hour,h.concluidos));
                }



              
            }
            catch
            {


                Concluidos = new ObservableCollection<Model>() {
                new Model("20:00",2),

                new Model("02:00",3)

            };



            }

        }
    }

    public class Model
    {
        public string hora { get; set; }

        public int Cantidad { get; set; }

        public Model(string xValue, int yValue)
        {
            hora = xValue;
            Cantidad = yValue;
        }
    }


    public class fecha {
        public string Fecha { get; set; }
    }
    public class datos {
        public string hour { get; set; }
        public int concluidos { get; set; }
        public int enproceso { get; set; }
        public int delays { get; set; }
    }
}
