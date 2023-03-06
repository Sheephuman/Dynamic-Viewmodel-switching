using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class CounterViewModel : INotifyPropertyChanged
    {
        public CounterViewModel()
        {

            CountDownCommand = new CountDownCommand(this);
            Counter = new CounterField();
            Counter.Value = 100;
        }


        /// <summary>
        /// View Modelのルールとして実装しておくイベントハンドラ
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Modelのインスタンスを保持するプロパティ
        public CounterField Counter { get; set; }

        /// <summary>
        /// カウンターの値を保持するクラス
        /// </summary>
        public class CounterField
        {
            public int Value {  get; set; }
        }



        /// <summary>
        /// コマンドを格納するプロパティ
        /// </summary>
        public CountDownCommand CountDownCommand { get; private set; }

        public int Value
        {
            get
            {
                 //カウンタークラスが保持するカウント値を返す

                return Counter.Value;
            }
            set
            {
                Counter.Value = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                }
            }

        }


    }
}
