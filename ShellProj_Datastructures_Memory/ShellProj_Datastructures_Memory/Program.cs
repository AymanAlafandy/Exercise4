using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ShellProj_Datastructures_Memory
{
    class Program
    {
        
        //Ayman
        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            //foregroundColor
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            

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
            Console.Clear();
            List<string> theTakingList = new List<string>();
            while (true)
            {
                Console.Write("Enter - to decrease or " +
                    "\nENTER + TO INCEASE YOUR LIST " +
                    "\nENTER 0 TO GO MAIN MENU" +
                    "\nENTER I FOR INFORMATION ABOUT YOUR LIST OF THINGS ");

                string switchInput = Console.ReadLine();
                switch (switchInput.ToUpper())
                {
                    case ("+"):
                        Console.WriteLine("ADD A NAME TO YOUR LIST");
                        string toTheList = Console.ReadLine();
                        theTakingList.Add(toTheList);
                        break;
                    case ("-"):
                        Console.WriteLine("DECREASE");
                        theTakingList.Remove(Console.ReadLine());
                        break;
                    case ("I"):
                        Console.WriteLine("THE NUMBER OF ELEMENTS IS:{0}\n" +
                            "THE ELEMENTS ARE ", theTakingList.Count);
                        foreach (string item in theTakingList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case ("0"):
                        return;
                    default:
                        Console.WriteLine("INVALID INPUT USE - OR +");

                        Console.WriteLine("THE ELEMENTS OF YOUR LIST IS: "+ theTakingList.Count());
                        break;
                }

            }
            
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
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
            Console.WriteLine("ENTER PEOPLE IN THE QUEUE OF ICA"+
                "\nWE WANT THEM TO REGISTER WHEN THEY BUY"+"\nENTER + TO ADD" +
                "\nENTER - TO REMOVE \nENTER 0 TO EXIT TO MAIN MENU " +
                "\nENTER I TO SHOW HOW MANY THINGS IS IN\n");
                string userInputForSwitch = Console.ReadLine();
                switch (userInputForSwitch.ToUpper())
                {
                    case ("+"):
                        Console.WriteLine("ADD NAME");
                        string inputForQueue = Console.ReadLine();
                        myFirstQueueInMyLife.Enqueue(inputForQueue);
                        Console.WriteLine("INPUT NUMBER {0} IS ADDED\n",myFirstQueueInMyLife.Count);
                        break;
                    case ("-"):
                        if (myFirstQueueInMyLife.Count > 0)
                        {
                            myFirstQueueInMyLife.Dequeue();
                            Console.WriteLine("YOUR LIST OF THINGS HADE DECERASED " +
                                                        "\nTHE NUMBER OF THINGS IS {0}", myFirstQueueInMyLife.Count);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("YOU CAN NOT DELETE ANYTHING " +
                                "\nBECAUSE YOU HAVE NOTHING IN YOUR QUEUE LIST OF THINGS");
                            break;
                        }
                        
                    //case ("i"):
                    case ("I"):
                        Console.WriteLine("THE NUMBER OF THINGS IS: "+myFirstQueueInMyLife.Count+"\nHERE YOU GO!");
                        foreach (string item in myFirstQueueInMyLife)
                        {
                            Console.WriteLine(item);
                        }
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
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            Console.Clear();
            Stack myFirstStackInMyLife = new Stack();
            while (true)
            {
                Console.WriteLine("ADD PEOPLE TO ICA:\n" +
                    "PUT + INCREASE THE PEOPLE" + "\nPUT - TO REMOVE THE LAST ONE COME TO ICA" +
                    "\nPUT 0 TO EXIT TO MAIN MENU");

                string switchInPut = Console.ReadLine();
                switch (switchInPut)
                {
                    case ("+"):
                        Console.WriteLine("ENTER A NAME: ");
                        string addInputToStack = Console.ReadLine();
                        myFirstStackInMyLife.Push(addInputToStack);
                        break;
                    case ("-"):
                        if (myFirstStackInMyLife.Count > 0)
                        {
                            Console.WriteLine("REMOVING THE LAST NAME: ");
                            Console.WriteLine("YOU POPPED OR KICKED OUT : " + myFirstStackInMyLife.Pop());
                            break;
                        }
                        else
                        {
                            Console.WriteLine("YOU CAN NOT REMOVE NOTHING BEACAUSE THERE THE STACK IS EMPTY ");
                            break;
                        }

                    case ("0"):
                        return;
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }

            }
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
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
