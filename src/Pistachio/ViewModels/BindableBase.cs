namespace Pistachio.ViewModels
{
    internal class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T originalValue, T newValue, [CallerMemberName] string propertyName = null)
        {
if(Equals(originalValue, newValue))
            {
                return false;
            }
originalValue = newValue;
            OnPropertyChange(propertyName);
            return true;
        }


    }
}
