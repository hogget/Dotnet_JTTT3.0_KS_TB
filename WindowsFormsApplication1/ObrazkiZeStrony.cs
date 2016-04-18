using System.Linq;
using System.Collections.Generic;

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

        public override List<string> Wykonaj()
        {
            return html.GetImagesFromPageWithKey(_url, _key);
        }
    }
}
