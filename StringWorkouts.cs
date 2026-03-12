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
            if(string.IsNullOrEmpty(name)||  name.Length<=1)
            {
                return name;
            }
            return reverse(name.Substring(1)) + name[0];
        }


        public int sumrecursion(int[] arr,int n)
        {
            if(n<=0)
            {
                return 0;
            }
            return arr[n - 1] + sumrecursion(arr, n - 1);
        }


        public void secondLongest(string sentance)
        {
            string[] words = sentance.Split(' ');
            string longest = "";
            string secondlong = "";

            foreach(var word in words)
            {
                if(word.Length > longest.Length)
                {
                    secondlong = longest;
                    longest = word;
                }
                else if(word.Length> secondlong.Length && word!=longest)
                {
                    secondlong = word;
                }
            }
            Console.WriteLine("second long is "+secondlong);
        }

    }
}
