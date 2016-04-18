using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Messagebox : IWyswietl
    {
        public string wiadomosc { get; set; }
        public Messagebox(string wiad)
        {
            wiadomosc = wiad;
        }

        public override void Wyswietl()
        {
            MessageBox.Show(wiadomosc);
        }
    }
}
