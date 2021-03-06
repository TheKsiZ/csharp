using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    class MagazineListHandlerEventArgs<TKey> : System.EventArgs
    {
        public string NameCollection { get; set; }
        public string Info { get; set; }
        public int Number { get; set; }

        public MagazineListHandlerEventArgs(string nameCollection, string info, int number)
        {
            NameCollection = nameCollection;
            Info = info;
            Number = number;
        }
        public override string ToString()
        {
            return $"{NameCollection}  {Info}   {Number}";
        }
    }
}
