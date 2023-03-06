using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class MainViewModelClass : INotifyPropertyChanged
    {



        public event PropertyChangedEventHandler PropertyChanged;

        private Action<object> _Execute;
        private Func<object, bool> _CanExecute;



        

        public string _text { get; set; } 

        public string Text
        {
            get => _text;
            set
            {
                if (_text != value)
                {
                    _text = value;
                    RaisePropertyChanged();
                }
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Text)));
                }
            }
        }
        public event PropertyChangedEventHandler propertyChangedHandler;

        

        private void RaisePropertyChanged([CallerMemberName] string ?propertyName = null)
 => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private DelegateCommand _setCommandand;
        public DelegateCommand SetCommand
        {
            get => this._setCommandand ?? (this._setCommandand = new DelegateCommand(
                _ => Text = "菅野よう子はドーセットダウン種", _ => !string.IsNullOrEmpty(this.Text)));
        }


    }

    
    
        class MainViewModel
        {
          public string Text { get; set; } = "菅野よう子はドーセットダウン種";
        }
    
}