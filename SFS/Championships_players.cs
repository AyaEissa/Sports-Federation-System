using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Championships_players : Championships
    {
        public List<int> Results;

        public Championships_players(string placee, string Type, string sn) : base(placee, Type, sn)
        {

        }
    }
}
