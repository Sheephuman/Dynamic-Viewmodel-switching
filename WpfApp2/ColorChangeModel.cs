using System.ComponentModel;
using System.Windows.Media;

namespace WpfApp2
{
    public class ColorChangeModel : INotifyPropertyChanged
    {

       public CurrentColorClass cuColor { get; set; }

       public CollorState cState { get; set; }

       public ColorChangeCommand cochange { get;  set; }
        
        public ColorChangeModel()
        {
          
            cuColor = new CurrentColorClass();

         //   cuColor.CurrentColor = Color.White;
            cState= new CollorState();

             cochange = new ColorChangeCommand(this);


            //CountDownCommand = new CountDownCommand(this);
            //Counter = new CounterField();
            //Counter.Value = 100;


        }


        //イテレーターを定義
        //public IEnumerator<Color> indexColorItelator()
        //{
        //    //yield return cState.BlackCo;
        //    //yield return cState.PinkCo;
        //    //yield return cState.YellowCo;
        //    //yield return cState.PurpleCo;
        //}

        //public Color picColor()
        //{
        //    var coEnumerator = indexColorItelator();
        //    //bool first = false;
            
        //    coEnumerator.MoveNext();
        //    Color CurrentColor = coEnumerator.Current;
        //    return CurrentColor;  
        //}


        /// <summary>
        /// Colorの値を保持する構造体
        /// </summary>
        public class CollorState
        {
            //public Color BlackCo => Color.Black;
            //public Color YellowCo => Color.Yellow;
            //public Color PinkCo => Color.Pink;
            //public Color PurpleCo => Color.Purple;
        }


        public class CurrentColorClass
        {
            public SolidColorBrush CurrentColor { get; set; }

        }


        public event PropertyChangedEventHandler ?PropertyChanged;


        public SolidColorBrush ColorValue
        {
            get { return cuColor.CurrentColor; }
            set
            {
               
                cuColor.CurrentColor = value;
                

                if (PropertyChanged != null)
                {
                   
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(ColorValue)));
                }
            }
         }

    }
}
