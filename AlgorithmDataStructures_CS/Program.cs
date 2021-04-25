using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataStructures_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an array here called grdsArray
            float[] grdsArray = new float[5];

            // Call the addGrades method, passing it the grdsArray
            addGrades(grdsArray);

            // After adding grades to the array, call the displayGrades method
            // to print out the grades to the console window
            // Use the foreach construct to iterate over the array
            displayGrades(grdsArray);

            // Create a new Stack object called myStack
            Stack myStack = new Stack();

            // Call the pushStack() method passing in the grades array for values
            pushStack(grdsArray, myStack);

            // Call the popStack() method twice to remove the top two items from stack
            // The popStack method will display each popped item to the console window
            popStack(myStack);
            popStack(myStack);

            // Create a new SortedList object called myCourses




            // Call the populateList() method




            // display a course in the list by passing a key




            // Remove an item from the myCourses list using the key

        }


        static void addGrades(float[] grdArray)
        {
            grdArray[0] = 82;
            grdArray[1] = 93;
            grdArray[2] = 85;
            grdArray[3] = 95;
            grdArray[4] = 88;
        }

        static void displayGrades(float[] grdArray)
        {
            Console.WriteLine("Grades are: ");
            foreach(float item in grdArray)
            {
                Console.WriteLine(item);
            }          
        }


        static void pushStack(float[] grdArray, Stack stack)
        {
            //for your lab ex2, as Kelly said, make sure u modify the pushstack method to have stack parameter as well
            foreach(float item in grdArray)
            {
                stack.Push(item);
            }
        }

        static void popStack(Stack stack)
        {
            Console.WriteLine("Item removed from the stack: ");
            float item = (float)stack.Pop();
            Console.WriteLine(item);
        }

        static void populateList(SortedList list)
        {

        }

        static void displayList(SortedList list, string key)
        {

        }

        static void removeListItem(SortedList list, string key)
        {

        }
    }
}
