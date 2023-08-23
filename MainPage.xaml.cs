using LAB09_MAUI_DataBindingLab.Model;

namespace LAB09_MAUI_DataBindingLab;

public partial class MainPage : ContentPage
{
    private ExpenseManager manager = new ExpenseManager();

    public MainPage()
	{
		InitializeComponent();
        SummaryList.SetModel(manager);
        NewTransaction.SetModel(manager);
    }


}

