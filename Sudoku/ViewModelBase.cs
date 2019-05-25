using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChangedHandler;

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged {
            add {
                throw new NotImplementedException();
            }

            remove {
                throw new NotImplementedException();
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedHandler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
