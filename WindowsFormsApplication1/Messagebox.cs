using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Messagebox : IWyswietl
    {
        public Messagebox() { }

        public override void Wyswietl(string wiadomosc)
        {
            MessageBox.Show(wiadomosc);
        }
    }
}
