using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    class Serializer
    {
        public void Serialize(BindingList<NewTask> taskBindingList, string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(fileStream, taskBindingList);
        }
        
        public BindingList<NewTask> Deserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            return (BindingList<NewTask>)formatter.Deserialize(fileStream);
        }
    }
}
