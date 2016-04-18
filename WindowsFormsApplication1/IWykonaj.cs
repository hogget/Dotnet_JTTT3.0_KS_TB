using System.Collections.Generic;
namespace WindowsFormsApplication1
{
    public abstract class IWykonaj
    {
        public virtual List<string> Wykonaj()
        {
            var output = new List<string>();
            return output;
        }
    }
}
