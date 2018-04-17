using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Championships
    {
        string Name;
        string place;
        string type;
        string senior;
        int results;
        public Championships()
        {
            Name = "";
            place = "";
             results = 0;
           
        }
        public Championships(string placee,string Type,string sn)
        {
            place = placee;
            type = Type;
            senior = sn;
            
        }
        public void setPlace(string place)
        {
            this.place = place;
        }
        public void setName(string n)
        {
            this.Name = n;
        }
        public string getName()
        {
            return this.Name;
        }
        public string GetPlace()
        {
            return this.place;
        }
        public void setresults(int results)
        {
            this.results = results;
        }
        public int Getresults()
        {
            return this.results;
        }

        public void settype(string type)
        {
            this.type = type;
        }
        public string gettype()
        {
            return this.type;
        }
        public void setsenior(string senior)
        {
            this.senior = senior;
        }
        public string getsenior()
        {
            return this.senior;
        }




    }
}
