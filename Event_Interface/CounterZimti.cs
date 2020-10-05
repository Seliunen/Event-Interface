using System;
using System.Threading;
using System.Threading.Tasks;

namespace Event_Interface
{
    public class CounterZimti
    {
        //EventHandler mit Tuples als Variablen
        public event EventHandler<(int,int)> SetZimtiValue;
        
        public delegate void MyHandler(object sender, ZimtiEventHandler e);
        public event MyHandler SetZimtiValue1;

        public IZimti ZimtStern { get; set; }

        public void Start()
        {
            for (int f = 0; f < 10; f++)
            {
                for (int i = 0; i < 10; i++)
                {
                    OnSetZimtiValue((i,f));

                    OnSetZimtiValue1(new ZimtiEventHandler(i, f));

                    ZimtStern?.PrintValue(i, f);
                    Thread.Sleep(100);
                }
            }

        }

        public async Task StartAsync()
        {
           await Task.Run(() =>
            {
                Start();
            });
        }


        protected virtual void OnSetZimtiValue1(ZimtiEventHandler e)
        {
            SetZimtiValue1?.Invoke(this, e);
        }

        protected virtual void OnSetZimtiValue((int,int) e)
        {
            SetZimtiValue?.Invoke(this, e);
        }

    }

    public class ZimtiEventHandler:EventArgs
    {
        public int InnerValue { get; set; }
        public int OuterValue { get; set; }

        public ZimtiEventHandler(int innerValue, int outerValue)
        {
            InnerValue = innerValue;
            OuterValue = outerValue;
        }
    }
}
