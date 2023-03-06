using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp2
{
    public class ColorChangeCommand : ICommand
    {
        public ColorChangeModel co { get; private set; }

        public ColorChangeCommand(ColorChangeModel command) 
        {
            co = command;
           
            ColorListIndex = new List<SolidColorBrush>() { Brushes.BlueViolet, Brushes.Red, Brushes.Azure };
            historyColor = new List<SolidColorBrush>();
            index= 1;
        }

        public IEnumerator<SolidColorBrush> indexColorItelator()
        {
            yield return Brushes.BlueViolet;
            yield return Brushes.Red;
            yield return Brushes.DarkBlue;
            //yield return cState.PurpleCo;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }


        /// <summary>
        /// コマンドを格納するプロパティ
        /// </summary>
        public ColorChangeCommand cChangeCommand { get; private set; }





        List<SolidColorBrush> ColorListIndex;
        List<SolidColorBrush> historyColor;
        int index { get; set; }
        public void Execute(object? parameter)
        {
            var ite = indexColorItelator();

            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    ite.MoveNext();
                }

                index++;

                if (index == ColorListIndex.Count+1)
                    index = 1;
                //historyColor.Clear();

            }                                         
            co.ColorValue = ite.Current;
                         
        }

        
    }
}
