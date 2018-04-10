using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Team
    {
        string Name;
        bool senior;
        List<int>res;

        public Team()
        {
            Name = "";
            senior = false;
        }
        public Team(string N,bool s)
        {
            Name = N;
            senior = s;
        }

        //setters and getters;
    }
}
