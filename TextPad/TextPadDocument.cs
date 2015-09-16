using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPad
{
    public class TextPadDocument : System.Collections.Generic.List<string>
    {
        private System.IO.StreamReader streamReader = null;
        public void Open(System.IO.Stream stream)
        {
            Clear();
            streamReader = new System.IO.StreamReader(stream);
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                Add(line);
            }
        }
        private System.IO.StreamWriter streamWriter = null;
        public void Save(System.IO.Stream stream)
        {
            streamWriter = new System.IO.StreamWriter(stream);
            foreach (string line in this)
            {
                streamWriter.WriteLine(line);
            }
            streamWriter.Flush();
        }
    }
}
