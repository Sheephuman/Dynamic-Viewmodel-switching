using System;
using System.Diagnostics.Metrics;
using System.Windows.Input;

namespace WpfApp2
{
    internal class CountDownCommand:ICommand
    {
        /// <summary>
        /// コマンドを読み出す側のクラス（View Model）を保持するプロパティ
        /// </summary>
        private CounterViewModel _view { get; set; }

        public CountDownCommand(CounterViewModel view)
        {
             _view = view;
            
        }

        public event EventHandler CanExecuteChanged
        {
            add {
                CommandManager.RequerySuggested += value; }
            remove { 
                CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// 実際の処理はここに書く。他のメソッドを呼ぶなどすれば意外と柔軟に書ける
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _view.Value = (
                _view.Value >= 0) ?
                _view.Value - 1 :
                100;
        }

    }
}
