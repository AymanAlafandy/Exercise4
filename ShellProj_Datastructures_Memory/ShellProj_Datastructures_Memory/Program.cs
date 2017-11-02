using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    class Program
    {


        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            bool run = true;
            while (true)
            {

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Please add or remove somthing from the list using '+' or '-'. ");
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            List<string> theList = new List<string>();
            bool examinelist = true;
            while (examinelist)
            {
                string stringInput = Console.ReadLine();// المستخدم يدخل شيئاً ما

                if (stringInput != "" && stringInput != null)// نتحقق من أن الإدخال ليسَ "لا شيء" ز
                {


                    char charOfStringInput = stringInput[0];


                    switch (charOfStringInput)
                    {
                        case '+':

                            Console.Clear();
                            string value = stringInput.Substring(1);
                            theList.Add(value);

                            Console.WriteLine("You just added: " + value + " to the list.\n");
                            Console.WriteLine("your capacity is:" + theList.Capacity + "\nAnd your count is:" + theList.Count);

                            break;
                        case '-':
                            Console.Clear();
                            string valueRe = stringInput.Substring(1);
                            theList.Remove(valueRe);
                            Console.WriteLine("You just removed: " + valueRe + " from the list.\n");
                            Console.WriteLine("your capacity is:" + theList.Capacity + "\nAnd your count is:" + theList.Count);

                            break;
                        case '0':
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("You should use one of the following '+' or '-'.");
                            break;
                    }


                }

            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            Console.Clear();

            Queue myFirstQueueInMyLife = new Queue();



            while (true)

            {

                Console.WriteLine("ENTER PEOPLE IN THE QUEUE OF ICA" +

                    "\nWE WANT THEM TO REGISTER WHEN THEY BUY" + "\nENTER + TO ADD" +

                    "\nENTER - TO REMOVE \nENTER 0 TO EXIT TO MAIN MENU " +

                    "\nENTER I TO SHOW HOW MANY THINGS IS IN" +
                    "\nENTER C TO CLEAR THE WINDOW!\n");

                string userInputForSwitch = Console.ReadLine();

                switch (userInputForSwitch.ToUpper())

                {

                    case ("+"):

                        Console.WriteLine("ADD NAME");

                        string inputForQueue = Console.ReadLine();

                        myFirstQueueInMyLife.Enqueue(inputForQueue);

                        Console.WriteLine("SECSEED!!!\nYOUR INPUT IS NOW IN THE QUEUE, AND ITS NUMBER IS {0}\n", myFirstQueueInMyLife.Count);

                        break;

                    case ("-"):

                        if (myFirstQueueInMyLife.Count > 0)

                        {


                            Console.WriteLine("YOUR LIST OF THINGS HADE DECERASED " +

                                                        "\nYOU KICKED OUT {0}\t;) \nTHE NUMBER OF THINGS IS {1}\n"
                                                        , myFirstQueueInMyLife.Dequeue() ,myFirstQueueInMyLife.Count );

                            break;

                        }

                        else

                        {



                            Console.WriteLine("YOU CAN NOT DELETE ANYTHING " +

                                "\nBECAUSE YOU HAVE NOTHING IN YOUR QUEUE LIST OF THINGS");

                            break;

                        }

                    case "C":
                        Console.Clear();
                        Console.WriteLine("CLEARING IS DONE!\n");
                        break;

                    //case ("i"):

                    case ("I"):
                        //Console.Clear();  @@@User can use C choise instead!!! 
                        Console.WriteLine("THE NUMBER OF THINGS IS: " + myFirstQueueInMyLife.Count + "\nHERE YOU GO!");

                        foreach (string item in myFirstQueueInMyLife)

                        {

                            Console.WriteLine(item);

                        }
                        Console.WriteLine();

                        break;



                    default:

                        Console.WriteLine("INVALID INPUT. TRY AGAIN\n");

                        break;



                    case ("0"):

                        return;

                }



            }

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */


            //switch (navv)
            //{
            //    case '1':

            //        break;

            //    case '2':

            //        break;

            //    case '0':
            //        return;
            //    default:
            //        Console.WriteLine("You should do something valid ");
            //        break;
            //}
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            //switch (nav)
            //{
            //    case '1':

            //        break;
            //    case '2':

            //        break;

            //    case '0':
            //        return;
            //    default:
            //        Console.WriteLine("Insert something valid ");
            //        break;
            //}
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
        }

    }
}