using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLLNode
    {
        public int num;   // field of the node
        public DLLNode next; // pointer to the next node
        public DLLNode previous; // pointer to the previous node
        public DLLNode (int num)
        {
            this.num = num;
            next = null;
            previous = null;
        } // end of constructor

        public Boolean isPrime(int n)
        {
            // WE DONT THIS boolean variable to check for true and false
            //Boolean b = true;

            if (n < 2)
            {
                // If n is less than 2, it's not a prime number
                return (false);
            }
            else
            {
                // Check for factors from 2 to the square root of n
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        //b = false;
                        //break;
                        // If n is divisible by i without remainder, it's not a prime number
                        return false;
                    }
                }
            }
            //return (b);
            // If none of the factors divided n evenly, it's a prime number
            return true;
        } // end of isPrime

    } // end of class DLLNode
}
