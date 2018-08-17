using System;

namespace InsertionSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //input handling
            Console.WriteLine("Select an option:");
            Console.WriteLine("1) 'I' for increasing order");
            Console.WriteLine("2) 'D' for decreasing order");
            string modeString = Console.ReadLine().ToUpper();
            while (!((modeString.Equals("D")) || (modeString.Equals("I")))){
                Console.WriteLine("Select an option I gave you, you dumbass!");
                modeString = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Enter an unsorted sequence of numbers separated by spaces:");
            String[] rawInput = Console.ReadLine().Split();
            int[] numberArray = new int[rawInput.Length];
            for (int i = 0; i < numberArray.Length; i++){
                numberArray[i] = int.Parse(rawInput[i]);
            }

            //insertion sort Algorithm
            if(modeString.Equals("D")){
                for (int j = 1; j < numberArray.Length;j++){
                    int key = numberArray[j];
                    int i = j - 1;
                    while (i>= 0 && numberArray[i]> key){
                        numberArray[i + 1] = numberArray[i];
                        i = i - 1;
                    }
                    numberArray[i + 1] = key;
                }
            }else{
                for (int j = 1; j < numberArray.Length; j++)
                {
                    int key = numberArray[j];
                    int i = j - 1;
                    while (i >= 0 && numberArray[i] < key)
                    {
                        numberArray[i + 1] = numberArray[i];
                        i = i - 1;
                    }
                    numberArray[i + 1] = key;
                }
            }

            //printing of results
            for (int i = 0; i < numberArray.Length; i++){
                Console.Write(numberArray[i] + " ");
            }

        }
    }
}
