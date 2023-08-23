

namespace LAB09_MAUI_DataBindingLab.Model
{
 
        public class Category : ObservableObjectBase
        {
            private string name;
            public string Name
            {
                get => name;
                set => SetAndNotifyIfChanged(ref name, value);
            }

            private bool isLuxury;
            public bool IsLuxury
            {
                get => isLuxury;
                set => SetAndNotifyIfChanged(ref isLuxury, value);
            }

            private string IsLuxuryAsString => IsLuxury ? "LUXUS" : "";
            public override string ToString() => $"{Name} {IsLuxuryAsString}";
        }
}

