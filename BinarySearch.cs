using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_1
{
   public class BinarySearch
    {
        public int Findtarget(int[]arr,int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while(left<=right)
            {
                int mid = (left + right) / 2;
                if (arr[mid]==target)
                {
                    return mid;
                }
                else if (arr[mid]<target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        public void Findfirstoccurence(int[]arr,int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            int first = -1,last=-1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target)
                {
                    first = mid;
                    right = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }

            //last occurence
             left = 0;
            right = arr.Length - 1;

            while(left<=right)
            {
                int mid = (left + right) / 2;
                if (arr[mid]==target)
                {
                    last = mid;
                    left = mid + 1;
                }
                else if (arr[mid]<target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                    
                }
            }

            Console.WriteLine("first :"+first +"last:"+last);
        }

    }
}
