using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab11.ViewModels
{
    public class ViewModelOperaciones : ViewModelBase 
    {

        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }


        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }



        int resultadoSuma, resultadoResta, resultadoMultiplicar, resultadoDividir;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }
        public int ResultadoResta
        {
            get { return resultadoResta; }
            set 
            {
                if (resultadoResta != value)
                {
                    resultadoResta = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ResultadoMultiplicar
        {
            get { return resultadoMultiplicar; }
            set
            {
                if (resultadoMultiplicar != value)
                {
                    resultadoMultiplicar = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ResultadoDividir
        {
            get { return resultadoDividir; }
            set
            {
                if (resultadoDividir != value)
                {
                    resultadoDividir = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }

        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {
                ResultadoSuma = ValorA + ValorB;
            });

            Restar = new Command(() =>
            {
                ResultadoResta = ValorA - ValorB;
            });

            Multiplicar = new Command(() =>
            {
                ResultadoMultiplicar += ValorA * ValorB;
            });

            Dividir = new Command(() =>
            {
                ResultadoDividir += ValorA / ValorB;
            });
        }

    }

}
