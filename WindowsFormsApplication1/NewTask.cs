namespace WindowsFormsApplication1
{
    public class NewTask
    {
        public IWyswietl Wyswietl { get; set; }
        public IWykonaj Wykonaj { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return "Task o nazwie: " + Name;
        }

        public void WykonajZadanie()
        {
            var napisyDoWyswietlenia = Wykonaj.Wykonaj();
            foreach (var napis in napisyDoWyswietlenia)
                Wyswietl.Wyswietl(napis);
        }
    }
}
