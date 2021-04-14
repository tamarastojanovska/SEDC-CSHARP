using System;

namespace Homework.Class04
{
    class Program
    {
        static void Main(string[] args)
        

        //            # Task 1
        //* Create a new method called FunWithStrings that will have one input parameter (string) and it will have no return
        //* In that method you should display in console the following tasks for the string:
        //  * print the reverse string
        //  * print total number of vowels
        //  * check if string is palindrome
        //  * print the largest word
        //  * print the smallest word
        //  * print the count of words
        //  * print the most used character (not space obviously)
        //* Ask the user to enter a string and call the method with that string.


        // {
        //                                               * print the reverse string
        //            string str1;


        //            Console.WriteLine("Hello");
        //            str1 = Console.ReadLine();


        //            char[] arr = str1.ToCharArray();
        //            Array.Reverse(arr);


        //            Console.WriteLine(new String(arr));



        //* print total number of vowels
        //    { 
        //    int total = 0;

        //    Console.WriteLine("Hello Tamara");
        //    string sentence = Console.ReadLine().ToLower();

        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        if (sentence.Contains("a") || sentence.Contains("e") || sentence.Contains("i") || sentence.Contains("o") || sentence.Contains("u"))
        //        {
        //            total++;
        //        }
        //    }
        //    Console.WriteLine("Your total number of vowels is: {0}", total);

        //    Console.ReadLine();
        //}



        // *check if string is palindrome


        //            string s, revs = "";
        //            Console.WriteLine(" Hello Tamaras");
        //            s = Console.ReadLine();
        //            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
        //            {
        //                revs += s[i].ToString();
        //            }
        //            if (revs == s) // Checking whether string is palindrome or not  
        //            {
        //                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
        //            }
        //            else
        //            {
        //                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
        //            }
        //            Console.ReadKey();
        //        }
        //    }
        //}

        // * print the longest word
        //        {
        //            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
        //            string[] words = line.Split(new[] { " Tamara" }, StringSplitOptions.None);
        //            string word = "";
        //            int ctr = 0;
        //            foreach (String s in words)
        //            {
        //                if (s.Length > ctr)
        //                {
        //                    word = s;
        //                    ctr = s.Length;
        //                }
        //            }

        //            Console.WriteLine(word);
        //        }
        //    }
        //}

        // * print the count of words
        //        {
        //            string str;
        //            int i, wrd, l;

        //            Console.Write("\n\nCount the total number of words in a string :\n");
        //            Console.Write("");
        //            Console.Write("Tamara ");
        //            str = Console.ReadLine();

        //            l = 0;
        //            wrd = 1;

        //            /* loop till end of string */
        //            while (l <= str.Length - 1)
        //            {
        //                /* check whether the current character is white space or new line or tab character*/
        //                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
        //                {
        //                    wrd++;
        //                }

        //                l++;
        //            }

        //            Console.Write("Total number of words in the string is : {0}\n", wrd);
        //        }
        //    }
        //}


                 //* Ask the user to enter a string and call the method with that string.


        {
            static void Ask(string question)
            {
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                Console.WriteLine(answer);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the cat store");
                Ask("How many cans do you odering");
                Console.WriteLine(answer);
            }
        }
    }












//## Task 2
//            *Create a new method that will remove extra space characters
//*Call the method with the following text: The & nbsp; &nbsp; &nbsp; best & nbsp; Lorem & nbsp; Ipsum & nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Generator in all the&nbsp; sea! & nbsp; &nbsp; Heave this & nbsp; scurvy copyfiller fer yar&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; next & nbsp; &nbsp; adventure & nbsp; and cajol yar clients&nbsp; &nbsp; into walking  the plank with ev'ry layout!&nbsp;&nbsp;&nbsp; Configure&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  above, then get yer pirate ipsum...own the high seas,&nbsp;&nbsp;&nbsp; argh!

//string followingString = "The & nbsp; &nbsp; &nbsp; best & nbsp; Lorem & nbsp; Ipsum & nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &";
//string trimmed = followingString.Trim();
//Console.WriteLine(trimmed);







// }
//  }
//}
