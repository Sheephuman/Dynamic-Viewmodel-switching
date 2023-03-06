using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class DelegateCommand : ICommand
    {
        public DelegateCommand(Action<object> Execute):this(Execute,null)
        {

        }

        public DelegateCommand(Action<object> Execute, Func<object, bool> CanExecute)
        {
            this._Execute = Execute;
            this._CanExecute = CanExecute;
        }


        public event EventHandler? CanExecuteChanged;
        private Action<object> _Execute;
        private Func<object, bool> _CanExecute;
        private Action<object> execute;
        private object value;

        public bool CanExecute(object parameter)
        {
            return (this._CanExecute != null) ? this._CanExecute(parameter) : true;
        }


        public void Execute(object? parameter)
        {
            if (this._Execute != null)
            {
                this._Execute(parameter);
            }
        }
    }
}
