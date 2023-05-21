using MAUICalc.MVVW.Models;
using PropertyChanged;
using System.Collections;
using System.Windows.Input;

namespace MAUICalc.MVVW.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {


        public CalculatorViewModel()
        {
            

        }

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Oper { get; set; }
        public double Result { get; set; }

        
        public string Numbers { get; set; }
        public string Results { get; set; }

        public ICommand ClickCommand0 => new Command(() => Numbers = Numbers += 0);
        public ICommand ClickCommand1 => new Command(() => Numbers = Numbers += 1);
        public ICommand ClickCommand2 => new Command(() => Numbers = Numbers += 2);
        public ICommand ClickCommand3 => new Command(() => Numbers = Numbers += 3);
        public ICommand ClickCommand4 => new Command(() => Numbers = Numbers += 4);
        public ICommand ClickCommand5 => new Command(() => Numbers = Numbers += 5);
        public ICommand ClickCommand6 => new Command(() => Numbers = Numbers += 6);
        public ICommand ClickCommand7 => new Command(() => Numbers = Numbers += 7);
        public ICommand ClickCommand8 => new Command(() => Numbers = Numbers += 8);
        public ICommand ClickCommand9 => new Command(() => Numbers = Numbers += 9);    
       
       
        public ICommand ClickCommandPoint => new Command(() => Numbers = Numbers += ".");

        public ICommand ClickCommandAdd => new Command(
            execute: () =>
            {
                Num1 = Convert.ToDouble(Numbers.ToString());
                Numbers = Numbers += " + ";
                Oper = "+";
            });

        public ICommand ClickCommandMin => new Command(
           execute: () =>
           {
               Num1 = Convert.ToDouble(Numbers.ToString());
               Numbers = Numbers += " - ";
               Oper = "-";
           });

        public ICommand ClickCommandMul => new Command(
           execute: () =>
           {
               Num1 = Convert.ToDouble(Numbers.ToString());
               Numbers = Numbers += " * ";
               Oper = "*";
           });

        public ICommand ClickCommandDiv => new Command(
           execute: () =>
           {
               Num1 = Convert.ToDouble(Numbers.ToString());
               Numbers = Numbers += " / ";
               Oper = "/";
           });

        public ICommand ClickEquals => new Command(
           execute: () =>
           {               
               string [] secNum = Numbers.Split(Oper);               
               Num2 = Convert.ToDouble(secNum[1].ToString());

               switch (Oper)
               {
                   case "+":
                       Result = Num1 + Num2;
                       Results = Result.ToString();
                       break;
                   case "-":
                       Result = Num1 - Num2;
                       Results = Result.ToString();
                       break;
                   case "/":
                       Result = Num1 / Num2;
                       Results = Result.ToString();
                       break;
                   case "*":
                       Result = Num1 * Num2;
                       Results = Result.ToString();
                       break;


                   default:
                       break;
               }   
                              
           });

        public ICommand ClickAC => new Command(
            execute: () =>
            {
                Num1 = 0;
                Num2=0;
                Result= 0;
                Numbers = "";
                Oper= "";
                Results = "";
            });

        public ICommand ClickDelete => new Command(
            execute: () =>
            {
               
                Numbers = Numbers.Remove(Numbers.Length -1);
            });
    }



}
