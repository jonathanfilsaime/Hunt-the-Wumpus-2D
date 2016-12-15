using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Check
    {
        Boolean notWin = false;
        public Boolean validRoomInput(int i)
        {
            if(0<i && i < 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean roomMatch(int adj1, int adj2, int adj3, int move)
        {
            if(move == adj1)
            {
                return true;
            }
            if (move == adj2)
            {
                return true;
            }
            if (move == adj3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String checkAdjacentRooms(String adj)
        {
            
            if(adj.Equals("wumpus"))
            {
                return "I smell a Wumpus";
            }
            if(adj.Equals("pit"))
            {
                return "I fell the wind"; 
            }
            if(adj.Equals("superbats"))
            {
                return "I hear bats";
            }
            else
            {
                return " ";
            }
            
        }

        public int life(String here)
        {
            Console.WriteLine("in life : ");
            if (here.Equals("wumpus"))
            {
                Console.WriteLine("in life : equals wumpus");
                return 100;
            }
            if (here.Equals("pit"))
            {
                Console.WriteLine("in life : equals pit");
                return 200;
            }
            if(here.Equals("superbats"))
            {
                Console.WriteLine("in life : equals superbats");
                return 300;
            }
            else
            {
                return 0 ;
            }
        }

        public Boolean win(int target1, int target2, int target3, int target4, int target5, int wumpusLoaction)
        {
            if(wumpusLoaction == target1 || wumpusLoaction == target2 || wumpusLoaction == target3 || wumpusLoaction == target4 || wumpusLoaction == target5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void changeNotWinToTrue()
        {
            notWin = true;
        }
    }
}
