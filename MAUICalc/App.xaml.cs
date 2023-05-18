using MAUICalculator.MVVW.Views;

namespace MAUICalc;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalculatorView();
	}
}
