using System;
using System.Collections.Generic;

namespace ISM6225_Assignment_2_Spring_2022_DA
{
    class Program
    {
       public static void Main(String[] args)
        {
            Console.WriteLine("Hello World!");


            
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 1, 2, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums1, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");
 




        

           //Question2:
           Console.WriteLine("Question 2");
                string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
                string[] banned = { "hit" };
                string commonWord = MostCommonWord(paragraph, banned);
                Console.WriteLine("Most frequent word is {0}:", commonWord);
                Console.WriteLine();

                //bring in example
                string text = ("Bob hit a ball, the hit BALL flew far after it was hit - A HOME-RUN. GREAT/GOOD FEELING!");
                Console.WriteLine(text);
                //change all text to lower case
                text = text.ToLower();
                //remove non-lettered characters from string
                text = text.Replace(",", "");
                text = text.Replace(".", "");
                text = text.Replace("-", "");
                text = text.Replace("/", "");
                text = text.Replace("!", "");
                text = text.Replace("hit", "");
                Console.WriteLine(text);

                //once the special characters are remove split the text by space
                string[] words = text.Split(' ');
                //foreach loop
                foreach (var word in words)
                {
                    Console.WriteLine($"{word}");
                }

                string[] splitban = text.Split(" ");
                Console.WriteLine(text);
                Console.WriteLine(splitban);
                Console.ReadLine();


                //need to count the words

        
             //Question 3:
            Console.WriteLine("Question 3");
            int[] arr1 = { 2, 2, 3, 3, 3, 3, 5, 6, 7 };
        //create gobal counter
        int element = 0;
        int count = 0;
        int luckNumber = 0;
            for (int i = 0; i<arr1.Length; i++)
        {
                //create temp counter for the gobal counter
                int tempElement = arr1[i];
        int tempCount = 0;
                for (int t = 0; t<arr1.Length; t++)
                    //if you find a matching element increase the tempCount by 1
                    if (arr1[t] == tempElement)
                             tempCount++;
                //just to see if tempCount is > than count if so update count with tempCount
                if (tempCount > count)
                {
                    element = tempElement;
                    count = tempCount;
                    //so i was trying to say if the count is equal to the element grab the element and input into luckNumber 
                    if (count == element) {
                        luckNumber = element;

                    }



                }
            Console.WriteLine("Your lucky number is:" + luckNumber);
            Console.ReadLine();
                
                
            //Question 4:
            Console.WriteLine("Question 4");
            string secret = "1807";
            string guess = "7810";
            //call a method called GetHint into the code
            //must have the method as public
            string hint = GetHint(secret, guess);
            Console.WriteLine("Hint for the guess is :{0}", hint);
            Console.WriteLine();
            Console.ReadLine();







            //Question 5:
            Console.WriteLine("Question 5");
            string s = "ababcbacadefegdehijhklij";
            List<int> part = PartitionLabels(s);
            Console.WriteLine("Partation lengths are:");
            for (int i = 0; i < part.Count; i++)
            {
            Console.Write(part[i] + "\t");
            }
            Console.WriteLine();

                 //Question 6:
                Console.WriteLine("Question 6");
                                int[] widths = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
                                string bulls_string9 = "abcdefghijklmnopqrstuvwxyz";
                                List<int> lines = NumberOfLines(widths, bulls_string9);
                                Console.WriteLine("Lines Required to print:");
                                for (int i = 0; i < lines.Count; i++)
                                {
                                    Console.Write(lines[i] + "\t");
                                }
                                Console.WriteLine();
                                Console.WriteLine();

                                //Question 7:
                                Console.WriteLine("Question 7:");
                                string bulls_string10 = "()[]{}";
                                bool isvalid = IsValid(bulls_string10);
                                if (isvalid)
                                    Console.WriteLine("Valid String");
                                else
                                    Console.WriteLine("String is not Valid");

                                Console.WriteLine();
                                Console.WriteLine();


            //Question 8:
            //create dictionary with letter to morse code translation
            IDictionary<string, string> UniqueMorseRepresentations = new Dictionary<string, string>();
            UniqueMorseRepresentations.Add("*-", "A");
            UniqueMorseRepresentations.Add("-***", "B");
            UniqueMorseRepresentations.Add("-*-*", "C");
            UniqueMorseRepresentations.Add("-**", "D");
            UniqueMorseRepresentations.Add("*", "E");
            UniqueMorseRepresentations.Add("**-*", "F");
            UniqueMorseRepresentations.Add("--*", "G");
            UniqueMorseRepresentations.Add("****", "H");
            UniqueMorseRepresentations.Add("**", "I");
            UniqueMorseRepresentations.Add("*---", "J");
            UniqueMorseRepresentations.Add("-*-", "K");
            UniqueMorseRepresentations.Add("*-**", "L");
            UniqueMorseRepresentations.Add("--", "M");
            UniqueMorseRepresentations.Add("-*", "N");
            UniqueMorseRepresentations.Add("---", "O");
            UniqueMorseRepresentations.Add("*--*", "P");
            UniqueMorseRepresentations.Add("--*-", "Q");
            UniqueMorseRepresentations.Add("*-*", "R");
            UniqueMorseRepresentations.Add("***", "S");
            UniqueMorseRepresentations.Add("-", "T");
            UniqueMorseRepresentations.Add("**-", "U");
            UniqueMorseRepresentations.Add("***-", "V");
            UniqueMorseRepresentations.Add("*--", "W");
            UniqueMorseRepresentations.Add("-**-", "X");
            UniqueMorseRepresentations.Add("-*--", "Y");
            UniqueMorseRepresentations.Add("--**", "Z");
            //test to see if the dictionary works
            foreach (KeyValuePair<string, string> kvp in UniqueMorseRepresentations)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            //i am not sure how to run the dictionary
            Console.WriteLine("Question 8");
            string[] bulls_string13 = { "gin", "zen", "gig", "msg" };
            string diffwords = UniqueMorseRepresentations(bulls_string13);
            //Console.WriteLine("Number of with unique code are: {0}", diffwords);
            Console.WriteLine(myDictionary);
            Console.WriteLine();
            Console.WriteLine();

                                //Question 9:
                                Console.WriteLine("Question 9");
                                int[,] grid = { { 0, 1, 2, 3, 4 }, { 24, 23, 22, 21, 5 }, { 12, 13, 14, 15, 16 }, { 11, 17, 18, 19, 20 }, { 10, 9, 8, 7, 6 } };
                                int time = SwimInWater(grid);
                                Console.WriteLine("Minimum time required is: {0}", time);
                                Console.WriteLine();

                                //Question 10:
                                Console.WriteLine("Question 10");
                                string word1 = "horse";
                                string word2 = "ros";
                                int minLen = MinDistance(word1, word2);
                                Console.WriteLine("Minimum number of operations required are {0}", minLen);
                                Console.WriteLine();
                        




            }


            //method for q4
            public static string GetHint(string secret, string guess)
            {
                int[] count = new int[10];
                //create a bin called bulls 
                int bulls = 0;
                //find bulls
                for (int i = 0; i < secret.Length; i++)
                {   //check if the current element is a bull
                    if (secret[i] == guess[i]) { bulls++; }
                    else { count[secret[i] - '0']++; }
                }
                //create a bin called cows
                int cows = 0;

                for (int i = 0; i < guess.Length; i++)
                {
                    if (secret[i] != guess[i] && count[guess[i] - '0'] > 0)
                    {
                        count[guess[i] - '0']--;
                        cows++;
                    }
                }
                //concat string to out the output like the example
                return bulls + "A" + cows + "B";


                //method for q1
                public static int SearchInsert(int[] arr, int target)
                {
                    //left side bin before split
                    int left = 0;
                    //left side bin before split
                    int right = arr.Length;
                    //while left is less than right find the mid-point
                    while (left < right)
                    {   //with the mid found split the list into two parts
                        int mid = (left + right) / 2;
                        //if the target is equal to the mid stop and return that value from the bin
                        if (arr[mid] == target) return mid;
                        //else keep looking
                        else if (arr[mid] > target)
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;

                        }

                    }
                    //return -1 becasue the position is starts at zero in C#
                    return -1;
                }
                //method for q5
                public static List<int> PartitionLabels(string s)
                {
                    //List<int> output_arr = new List();
                    int start = 0;
                    int end = 0;

                    int[] lastElement = new int[26];
                    for (int i = 0; i < s.Length; i++)
                    {
                        //trying to convert the int back to string to compare against a string
                        lastElement[s[i] - 'a'] = i;

                    }
                    List<int> outString = null;
                    return outString;


                    //method for q6
                    public static List<int> NumberOfLines(int[] widths, string bulls_string9)
                    {
                        int lines = 1, width = 0;

                        foreach (char i in bulls_string9)
                        {
                            width += widths[i - 'a'];
                            //check to see if under 100 pixels
                            if (width > 100)
                            {
                                lines++;
                                width = widths[i - 'a'];
                            }
                        }
                        //can you explain this error
                        return new int { lines, width };


                        //method for q7
                        private static bool IsValid(string bulls_string10)
                        {
                            //i don't know how to do this problem
                            //i was think i could store the first symbol and compare it with the next symbol in the list

                            string str = bulls_string10;
                            string last = "";

                            for (int i = 0; i < str.Length; i++)
                            {


                                if (str[i] == '(')
                                {
                                    last = i;
                                }
                                else if (str[i] == '[')
                                {
                                    last = i
                                }

                            }
                        }
                        //keep running until the string finshed
                        return last == bulls_string10;

                    }
                }
}
