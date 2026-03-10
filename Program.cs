using DataStructure_1;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array

            Program obj = new Program();
            //obj.arrayReverse();
            //obj.secondLargest();
            //obj.Kthlargets();



            //singly linkedlist

            LinkedlistPractice practice = new LinkedlistPractice();
            practice.addNode(12);
            practice.addNode(15);
            
            practice.insertAtBegning(20);
            practice.insertAtEnd(30);
            practice.Insertatspecific(32, 3);
            practice.disply();
            //practice.kthelement(3);
            //practice.findmiddle();
            practice.reverseLL();
        }




        public void arrayReverse()
        {
            int[] arr = { 2, 3, 4, 5, 6 };
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        //second largest number in an array
        public void secondLargest()
        {
            int[] arr = { 2, 3, 4, 5, 6 };

            int largest = 0;
            int secondlarge = 0;
            int thirdlarge = 0;

            foreach(var num in arr)
            {
                if (num > largest)
                {
                    thirdlarge = secondlarge;
                    secondlarge = largest;
                    largest = num;

                }
                else if (num > secondlarge && num != largest)
                {
                    thirdlarge = secondlarge;
                    secondlarge = num;
                }
                else if (num > thirdlarge && num != secondlarge&& num!=largest)
                {
                    thirdlarge = num;
                }
            }
            Console.WriteLine(thirdlarge);
        }


        public void Kthlargets()
        {
            int[] arr = { 5, 6, 7, 8, 3, 4 };
            //3,4,5,6,7,8-sorted

            int k = 3;
            Array.Sort(arr);

            int result = arr[arr.Length - k];
            Console.WriteLine(result);
        }
    }

}