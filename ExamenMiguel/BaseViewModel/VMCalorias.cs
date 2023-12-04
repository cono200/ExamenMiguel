using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenMiguel.BaseViewModel
{
    public class VMCalorias : BaseViewModel
    {
        //VARIABLES SIUUU
        double _peso;
        double _tiempo;
        double _resultado;
        double _tipoImagen;
        
        //CONTRUCTOR
        //public *clase*(Inavigation navigation){
        public VMCalorias(INavigation navigation)
        {
            Navigation = navigation;
        }
        //Navigation = navigation


        public double Peso
        {
            get { return _peso; }
            set { SetValue(ref _peso, value); }
        }

        public double Tiempo
        {
            get { return _tiempo; }
            set { SetValue(ref _tiempo, value); }
        }

        public double Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        



        //}

        //PROCESOS
        //A PARA MINUTOS 
        //B PARA PESO
        public void CalcularCalorias1(double a, double b)
        {
            double resu = a * 10 * b / 200;
        }

        public void CalcularCaloriasDefinitiveEdition()
        {
            CalcularCalorias1(Peso, Tiempo);
            Resultado = (Tiempo * 10 * Peso)/200;


            if (Resultado < 250)
            {
                DisplayAlert("Informacion", "Debes de correr mas esfuerzate!", "Ok");
                
            }

            else if (Resultado >= 250 && Resultado <=499)
            {
                DisplayAlert("Informacion", "Vas por el buen 'camiono' sigue asi :D", "ok");
            }
            else
            {
                DisplayAlert("Informacion", "Felicidades vas muy bien", "ok");

            }

            //250 y 499
        }


        public ICommand CalcularCalorias => new Command(CalcularCaloriasDefinitiveEdition);


        //COMANDOS
        //public ICommand nombreCreo = > new command(proceso) 


    }
}
