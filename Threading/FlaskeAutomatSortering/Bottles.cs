using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskeAutomatSortering
{
    class Bottles
    {
        //type string is either soda or beer
        string type;
        //the ID to keep track of what bottle is unique and how many is made
        int id;
        //contructer for the object
        public Bottles(string type, int id)
        {
            this.type = type;
            this.id = id;
        }
        //properties for the object
        public string Type { get => type; }
        public int Id { get => id; }
    }
}
