using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    class SortEditName : IComparer<Edition>
    {
        public int Compare(Edition edition, Edition edition1)
        {
            if (edition.NameOfEdition[0] > edition1.NameOfEdition[1]) return 1;
            else if (edition.NameOfEdition[0] < edition1.NameOfEdition[1]) return -1;
            else return 0;
        }
    }
    class SortEditDate : IComparer<Edition>
    {
        public int Compare(Edition edition, Edition edition1)
        {
            if (edition.Date > edition1.Date) return 1;
            else if (edition.Date < edition1.Date) return -1;
            else return 0;
        }
    }
    class SortEditCountOfPub : IComparer<Edition>
    {
        public int Compare(Edition edition, Edition edition1)
        {
            if (edition.CountOfPublicashion > edition1.CountOfPublicashion) return 1;
            else if (edition.CountOfPublicashion < edition1.CountOfPublicashion) return -1;
            else return 0;
        }
    }
}
