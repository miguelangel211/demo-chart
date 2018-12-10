using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using Syncfusion;
using Syncfusion.SfChart.XForms;

namespace demo_chart
{
    public class ViewModel
    {
        public ObservableCollection<Model> Concluidos { get; set; }

        public ObservableCollection<Model> Proceso { get; set; }
        public ObservableCollection<Model> Delays { get; set; }
        public ObservableCollection<ChartDataPoint> donut { get; set; }
        public ObservableCollection<ChartDataPoint> restante { get; set; }

        public ViewModel()
        {
            Concluidos = new ObservableCollection<Model>();
                Proceso = new ObservableCollection<Model>();
            Delays = new ObservableCollection<Model>();
            donut = new ObservableCollection<ChartDataPoint>();
            restante = new ObservableCollection<ChartDataPoint>();

            call(JsonConvert.SerializeObject(new fecha { Fecha= "2017-09-29" }));
            
        }


        public void call(string fecha) {


            Concluidos = new ObservableCollection<Model>() {
             //   new Model("12a",0),
               // new Model("1a",0),
                //new Model("2a",0),
                //new Model("3a",0),
                //new Model("4a",0),
                new Model("5a",0),
                new Model("6a",0),
                new Model("7a",0),
                new Model("8a",0),
                new Model("9a",0),
                new Model("10a",1),
                new Model("11a",2),
                new Model("12p",2),
                new Model("1p",2),
                new Model("2p",2),
                new Model("3p",1),
                new Model("4p",0),
                new Model("5p",0),
                new Model("6p",0),
                new Model("7p",0),
                new Model("8p",0),
               // new Model("9p",0),
             //   new Model("10p",0),


            };

            Proceso = new ObservableCollection<Model>() {
               // new Model("12a",0),
                //new Model("1a",0),
                //new Model("2a",0),
                //new Model("3a",0),
                //new Model("4a",0),
                new Model("5a",0),
                new Model("6a",0),
                new Model("7a",1),
                new Model("8a",2),
                new Model("9a",3),
                new Model("10a",2),
                new Model("11a",1),
                new Model("12p",0),
                new Model("1p",0),
                new Model("2p",0),
                new Model("3p",0),
                new Model("4p",0),
                new Model("5p",0),
                new Model("6p",0),
                new Model("7p",0),
                new Model("8p",0),
                //new Model("9p",0),
                //new Model("10p",0),


            };


            Delays = new ObservableCollection<Model>() {
                //new Model("12a",0),
                //new Model("1a",0),
                //new Model("2a",0),
                //new Model("3a",0),
                //new Model("4a",0),
                new Model("5a",0),
                new Model("6a",0),
                new Model("7a",0),
                new Model("8a",0),
                new Model("9a",0),
                new Model("10a",0),
                new Model("11a",0),
                new Model("12p",0),
                new Model("1p",0),
                new Model("2p",0),
                new Model("3p",0),
                new Model("4p",1),
                new Model("5p",2),
                new Model("6p",2),
                new Model("7p",1),
                new Model("8p",0),
                //new Model("9p",0),
                //new Model("10p",0),


            };
            donut = new ObservableCollection<ChartDataPoint>()
            {
                new ChartDataPoint("Porcentaje",65),
                new ChartDataPoint("restante",35)

            };
            restante = new ObservableCollection<ChartDataPoint>()
            {
                new ChartDataPoint("restante",35),
               new ChartDataPoint("Porcentaje",65),

            };
        }
    }

    public class Model
    {
        public string hora { get; set; }

        public double Cantidad { get; set; }

        public Model(string xValue, double yValue)
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

    public class donut {
        public string Expense { get; set; }
        public double Value { get; set; }
        public donut(string xExpense,double yValue) {
            Expense = xExpense;
            Value = yValue;
        }

    }
}
