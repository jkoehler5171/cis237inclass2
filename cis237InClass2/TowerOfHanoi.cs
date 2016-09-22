using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class TowerOfHanoi
    {
        private int moveCounter = 0;

        public TowerOfHanoi()
        {
            
            Console.WriteLine("Enter the number of disks to use. Less than five is ideal.");
            string input = Console.ReadLine();
            int diskNumber = Int32.Parse(input);

            //Make the first call to MoveDisk to start the solution of the problem
            MoveDisk(diskNumber, 'A', 'B', 'C');

            Console.WriteLine(moveCounter + " Total moves made!");


        }

        private void MoveDisk(int n, char source, char aux, char destination)
        {
            

            if (n == 1)
            {
                Console.WriteLine("Move disk from tower {0} to tower {1}", source, destination);
                moveCounter++;
            }
            else
            {
                //Make a recursive call to move n -1 disks from the source peg to the aux peg
                MoveDisk(n - 1, source, destination, aux);
                //Make a recursive call to move the 1(bottom disk) from source to destination
                MoveDisk(1, source, aux, destination);
                //Make a recursive call to move n-1 disks from aux to destination
                MoveDisk(n - 1, aux, source, destination);
            }  
        }

    }
}
