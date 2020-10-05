using System;
using System.Windows.Forms;

namespace Event_Interface
{
    public partial class Form1 : Form, IZimti
    {

        private static CounterZimti _item;
        string text;
        

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _item = new CounterZimti();

            _item.SetZimtiValue1 += (object sender, ZimtiEventHandler e) =>
            {
                text = $"Außen: {e.OuterValue} Innen: {e.InnerValue}";
                lock (this)
                {
                    UpdateUiZimtiEventHandler(text); 
                }
            };


            _item.SetZimtiValue += (object sender, (int, int) e) =>
            {
                text = $"Außen: {e.Item2} Innen: {e.Item1}";
                lock (this)
                {
                    UpdateUiTuples(text);
                }
            };


            _item.ZimtStern = this;

        }

        //private void ItemSetZimtiValue(object sender, string e)
        //{
        //    lock (this)
        //    {
        //        UpdateUi(e);
        //    }
        //}

        private void UpdateUiTuples(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUiTuples(text)));
                return;
            }
            Tuples.Text = text;
        }



        private void UpdateUiZimtiEventHandler(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUiZimtiEventHandler(text)));
                return;
            }
            ZimtiEventHandlerLabel.Text = text;
        }



        private void UpdateUi(string e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUi(e)));
                return;
            }
            Zimti.Text = e;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await _item.StartAsync();
        }

        public void PrintValue(int innerValue, int outerValue)
        {
            text = $"Außen: {outerValue} Innen: {innerValue}";
            lock (this)
            {
                UpdateUi(text);
            }
        }
    }
}
