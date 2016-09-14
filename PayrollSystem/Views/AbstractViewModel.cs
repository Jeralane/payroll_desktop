using System.ComponentModel;
using System.Text;
using PayrollSystem.Models;

namespace PayrollSystem.Views
{
    public abstract class AbstractViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void RefreshCollection() 
        {
            throw new System.NotImplementedException();
        }
    }


}
