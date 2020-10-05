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
            //_item.SetZimtiValue += (object sender, string e) =>
            //{
            //    lock (this)
            //    {
            //        UpdateUi(e);
            //    }
            //};
            _item.ZimtStern = this;

        }

        //private void ItemSetZimtiValue(object sender, string e)
        //{
        //    lock (this)
        //    {
        //        UpdateUi(e);
        //    }
        //}

        private void UpdateUiIn(string e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUiIn(e)));
                return;
            }
            Zimti.Text = e;
        }

        private void UpdateUiOut(string e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUiOut(e)));
                return;
            }
            Außen.Text = e;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await _item.StartAsync();
        }

        public void PrintValueOut(int Out)
        {
            text = $"Äußeren Schleife: {Out}";

            lock (this)
            {
                UpdateUiOut(text);
            }
        }

        public void PrintValueIn(int In)
        {
            text = $"Innere Schleife: {In}";

            lock (this)
            {
                UpdateUiIn(text);
            }
        }

        //public void PrintValue(string text)
        //{
        //    lock (this)
        //    {
        //        UpdateUi(text);
        //    }
        //}
    }
}
