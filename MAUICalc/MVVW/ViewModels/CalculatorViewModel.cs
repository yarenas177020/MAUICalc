using PropertyChanged;
using System.Windows.Input;

namespace MAUICalc.MVVW.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {

        public CalculatorViewModel()
        {


        }

        public string Num1 { get; set; } = "1";

        public string Numbers { get; set; }

        public ICommand ClickCommand => new Command(() => Numbers = Numbers += Num1);

        void AddDigit()
        {
            Numbers = Numbers += Num1;
        }

    }



}
