using LAB09_MAUI_DataBindingLab.Model;
using System.ComponentModel;
using LAB09_MAUI_DataBindingLab.ViewModel;

namespace LAB09_MAUI_DataBindingLab.View
{

	public partial class NewTransaction : ContentView
	{
        private TransactionList Transactions;

        public CategoryList Categories { get; private set; }

        #region Values entered into the form
        public int SelectedCategoryIndex { get; set; } = 0;
        public string Description { get; set; }
        public int Value { get; set; }
        #endregion

        public NewTransaction()
        {
            this.BindingContext = this;
            InitializeComponent();
        }

        internal void SetModel(ExpenseManager expenseManager)
        {
            this.Transactions = expenseManager.Transactions;
            this.Categories = expenseManager.Categories;
            OnPropertyChanged(nameof(Transactions));
            OnPropertyChanged(nameof(Categories));
        }

        private void AddTransactionClicked(object sender, EventArgs e)
        {
        }
    }
}
