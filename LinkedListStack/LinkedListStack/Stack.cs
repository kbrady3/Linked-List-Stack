using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**************************************************************
* Name        : LinkedListStack
* Author      : Kabrina Brady
* Created     : 2/26/2021
* Course      : Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

namespace LinkedListStack
{
    public class Stack
    {
        // Members
        private int top;  // Will hold the index of the last value present in the stack
        private int maxSize; // Will hold a number that represents the maximum size of the stack
        private List<string> stackItems;

        public Stack()
        {
            this.maxSize = 5;
            this.top = -1;
            this.stackItems = new List<string>();
        }

        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
            this.top = -1;
            this.stackItems = new List<string>();
        }

        public bool IsFull()
        {
            return top == maxSize - 1; // Returns a bool representing whether top is equal to maxSize - 1
        }

        public bool IsEmpty()
        {
            if(stackItems.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            return stackItems.Count;
        }

        public string Peek()
        {
            if (!this.IsEmpty()) // Necessary to check whether the array contains something, otherwise there's nothing to show
                return stackItems[top];
            throw new Exception("Stack empty");
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack empty");
            }
            else
            {
                //Set top
                for (int i = 0; i < stackItems.Count; i++)
                {
                    if (string.IsNullOrEmpty(stackItems[i]))
                    {
                        //Gets the index of the last not null value
                        top = i - 1;
                        break;
                    }
                }

                string item = null;
                string poppedValue = stackItems[top];
                stackItems[top] = item;

                //Sets new top
                if (!(top == 0))
                {
                    top -= 1;
                }

                return poppedValue;
            }
        }


        public void Push(string item)
        {
            //Set top
            for (int i = 0; i < stackItems.Count; i++)
            {
                if (string.IsNullOrEmpty(stackItems[i]))
                {
                    //Gets the index of the last not null value
                    top = i - 1;
                    break;
                }
            }

            try
            {
                stackItems.Add(item);
                //Sets new top
                top += 1;
            }
            catch
            {
                throw new Exception("Stack full");
            }
        }

        public string PrintStackUp()
        {
            string stackString = "";

            if (IsEmpty())
            {
                throw new Exception("Stack empty");
            }
            else
            {
                for (int i = 0; i < stackItems.Count; i++)
                {
                    //Prints each item on a new line
                    stackString += stackItems[i] + "\n";
                }
            }
            return stackString;
        }
    }
}
