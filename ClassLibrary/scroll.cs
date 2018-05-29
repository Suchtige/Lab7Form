using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public partial class scroll
    {
        public int scrollID { get; set; }
        public string scrollName { get; set; }
        public double scrollStrength { get; set; }

        public scroll (int scrollID, string scrollName, double scrollStrength)
        {
            this.scrollID = scrollID;
            this.scrollName = scrollName;
            this.scrollStrength = scrollStrength;
        }

        public virtual void info()
        {
            Console.WriteLine("Код номенклатуры: {0}\nНазвание номенклатуры: {1}\nГрадус: {2}", 
                scrollID, scrollName, scrollStrength);
        }

        public override string ToString()
        {
            return scrollID.ToString() + ": " + scrollName;
        }
    }
}
