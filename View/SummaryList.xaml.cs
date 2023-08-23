using LAB09_MAUI_DataBindingLab.Model;
using LAB09_MAUI_DataBindingLab.ViewModel;
using System.ComponentModel;

namespace LAB09_MAUI_DataBindingLab.View
{
    public sealed partial class SummaryList : ContentView
    {
        public SummaryListViewModel List { get; private set; }
        public SummaryList()
        {
            this.BindingContext = this;
            this.InitializeComponent();
        }

        public void SetModel(ExpenseManager expenseManager)
        {
            this.List = new SummaryListViewModel(expenseManager.Transactions);
            OnPropertyChanged(nameof(List));
        }
    }
}
