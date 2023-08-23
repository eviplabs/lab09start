
using LAB09_MAUI_DataBindingLab.Model;
using System.Collections.ObjectModel;


namespace LAB09_MAUI_DataBindingLab.ViewModel
{
    public class SummaryListViewModel : ObservableCollection<SummaryListItemViewModel>
    {
        public SummaryListViewModel(TransactionList model)
        {
            model.CollectionChanged += Model_CollectionChanged;
        }

        private void Model_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // Add new view models for the appearing items and remove view model
            //  belonging to disappearing items.
            if (e.NewItems != null)
                foreach (Transaction item in e.NewItems)
                    this.Add(new SummaryListItemViewModel(item));
            if (e.OldItems != null)
            {
                var toRemove = this.Items.Where(i => e.OldItems.Contains(i.Model));
                foreach (var vm in toRemove)
                    this.Remove(vm);
            }
        }
    }
}
