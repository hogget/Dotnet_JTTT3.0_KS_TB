using System.Linq;

namespace WindowsFormsApplication1
{
    public class ObrazkiZeStrony : IWykonaj
    {
        readonly Html html = new Html();
        public string _url { get; set; }
        public string _key { get; set; }

        public ObrazkiZeStrony(string url, string key)
        {
            _url = url;
            _key = key;
        }

        public override string Wykonaj()
        {
            var list = html.GetImagesFromPageWithKey(_url, _key);
            return list[0];
        }

    }
}
