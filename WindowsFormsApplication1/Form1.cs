using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public BindingList<NewTask> ListaTaskow;
        public Form1()
        {
            InitializeComponent();
            ListaTaskow = new BindingList<NewTask>();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            var myTask = new NewTask();
            myTask.Name = nazwaBox.Text;

            bool wykonujeWysylanieEmailem = wyslij_email.Checked;
            bool wykonujemySprawdzeniePogody = tempBox.Text.Length == 0;

            if (wykonujeWysylanieEmailem)
            {
                var wyswietl = new EMail("aga.michalik788@gmail.com", "javaandfriends");
                wyswietl.InsertData(Email.Text, "To powinno Cie zainteresowac !!!");
                myTask.Wyswietl = wyswietl;
            }  
            else
            {
                var wyswietl = new Messagebox();
                myTask.Wyswietl = wyswietl;
            }

            if(wykonujemySprawdzeniePogody)
            {
                var wykonaj = new Weather(Klucz.Text, Convert.ToDouble(tempBox.Text));
                myTask.Wykonaj = wykonaj;
            }
            else
            {
                var wykonaj = new ObrazkiZeStrony(Adres_strony.Text, Klucz.Text);
                myTask.Wykonaj = wykonaj;
            }

            using (var context = new JtttContext())
            {
               // context.MyTasks.Add(myTask);
                context.SaveChanges();
            }

            ListaTaskow.Add(myTask);
            lista_zadan.DataSource = ListaTaskow;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void wykonajPojedynczegoTaska(NewTask TaskDoWykonania)
        {
            TaskDoWykonania.WykonajZadanie();
        }

        private void WykonajZadaniaZListy(object sender, EventArgs e)
        {
            foreach (var task in ListaTaskow)
            {
                wykonajPojedynczegoTaska(task);
            }
        }

        private void WyczyscListe(object sender, EventArgs e)
        {
            ListaTaskow.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Serialize(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.Serialize(ListaTaskow, "Dane.dat");
        }

        private void Deserialize(object sender, EventArgs e)
        {
            Serializer deserializer = new Serializer();
            ListaTaskow = deserializer.Deserialize("Dane.dat");
        }

        private void Adres_strony_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tempBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nazwaBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
