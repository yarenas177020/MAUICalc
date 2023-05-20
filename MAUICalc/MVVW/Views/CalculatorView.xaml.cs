using MAUICalc.MVVW.ViewModels;

namespace MAUICalculator.MVVW.Views;

public partial class CalculatorView : ContentPage
{
	public CalculatorView()
	{
		InitializeComponent();
		BindingContext = new CalculatorViewModel();
	}
}