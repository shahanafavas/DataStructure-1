using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_1
{
   public class StringWorkouts
    {
        
        public string reverse(string name)
        {
            if(  name.Length<=1)
            {
                return name;
            }
            return reverse(name.Substring(1)) + name[0];
        }
    }
}
