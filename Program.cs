using System;

namespace sdgfsdfg
{
    class Program
    {
        static int binarySearch(int[] anArray, int item){
            int lower_index = 0;
            int upper_index = anArray.Length - 1;
            while (lower_index <= upper_index){
                int middle_index = (lower_index + upper_index)/2;
                if(item == anArray[middle_index]){
                    return middle_index;
                }else if(item < anArray[middle_index]){
                    upper_index = middle_index-1;
                }else{
                    lower_index = middle_index+1;
                }
            }
            return -1;
        }

        static int binarySearchStr(string[] anArray, string item){
            int lower_index = 0;
            int upper_index = anArray.Length - 1;
            while (lower_index <= upper_index){
                int middle_index = (lower_index + upper_index)/2;
                if(item == anArray[middle_index]){
                    return middle_index;
                }else if(string.Compare(item,anArray[middle_index])<0){
                    upper_index = middle_index-1;
                }else{
                    lower_index = middle_index+1;
                }
        }
        return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = {10, 30, 40, 45, 70, 80, 85, 90, 100};
            string[] words = {"at", "ball", "cat", "dog", "eye", "fish", "good"};
            int[] unsorted = {30, 20, 70, 40, 50, 100, 90};
            Console.WriteLine(binarySearch(nums, 100)); //8
            Console.WriteLine(binarySearch(nums, 75));  //-1
            Console.WriteLine(binarySearchStr(words, "fish")); //5
            Console.WriteLine(binarySearchStr(words, "at"));    //0
            Console.WriteLine(binarySearch(unsorted, 70));  //-1
        }
    }
}
