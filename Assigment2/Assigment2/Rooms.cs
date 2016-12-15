using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Rooms
    {
        int wumpusLoaction;

        int[] adj1 = new int[] { 5, 8, 2 };
        int[] adj2 = new int[] { 1, 10, 3 };
        int[] adj3 = new int[] { 2, 12, 4 };
        int[] adj4 = new int[] { 3, 14, 5 };
        int[] adj5 = new int[] { 4, 6, 1 };
        int[] adj6 = new int[] { 5, 7, 15 };
        int[] adj7 = new int[] { 6, 8, 17 };
        int[] adj8 = new int[] { 7, 9, 1 };
        int[] adj9 = new int[] { 8, 10, 18 };
        int[] adj10 = new int[] { 9, 2, 11 };
        int[] adj11 = new int[] { 10, 12, 19 };
        int[] adj12 = new int[] { 11, 13, 3 };
        int[] adj13 = new int[] { 12, 14, 20 };
        int[] adj14 = new int[] { 15, 13, 4 };
        int[] adj15 = new int[] { 16, 14, 6 };
        int[] adj16 = new int[] { 15, 20, 17 };
        int[] adj17 = new int[] { 7, 16, 18 };
        int[] adj18 = new int[] { 17, 9, 19 };
        int[] adj19 = new int[] { 18, 11, 20 };
        int[] adj20 = new int[] { 19, 16, 13 };

        String[] content = new String[25];

        SortedList<int, int[]> rooms = new SortedList<int, int[]>();

        public void fillContent()
        {
            for (int i = 0; i < 25; i++)
                content[i] = "not here";
        } 

        public void roomSetup()
        {
                rooms.Add(1, adj1);
                rooms.Add(2, adj2);
                rooms.Add(3, adj3);
                rooms.Add(4, adj4);
                rooms.Add(5, adj5);
                rooms.Add(6, adj6);
                rooms.Add(7, adj7);
                rooms.Add(8, adj8);
                rooms.Add(9, adj9);
                rooms.Add(10, adj10);
                rooms.Add(11, adj11);
                rooms.Add(12, adj12);
                rooms.Add(13, adj13);
                rooms.Add(14, adj14);
                rooms.Add(15, adj15);
                rooms.Add(16, adj16);
                rooms.Add(17, adj17);
                rooms.Add(18, adj18);
                rooms.Add(19, adj19);
                rooms.Add(20, adj20);
        }

        public void wampusLocation(int i)
        {
            content[i] = "wumpus";
            wumpusLoaction = i;
        }

        public void pitLocation(int i)
        {
            content[i] = "pit";
        }

        public void superBatsLocation(int i)
        {
            content[i] = "superbats";
        }

        public String getContent(int i)
        {
            return content[i];
        }

        public int getAdj1(int i)
        {
            
            return rooms.ElementAt(rooms.IndexOfKey(i)).Value[0];
        }
        public int getAdj2(int i)
        {
            return rooms.ElementAt(rooms.IndexOfKey(i)).Value[1];
        }
        public int getAdj3(int i)
        {
            return rooms.ElementAt(rooms.IndexOfKey(i)).Value[2];
        }
        public int getWumpusLocation()
        {
            return wumpusLoaction;
        }
        public void setContentToIndex(int i)
        {
            content[i] = "not here";
        }
    }
}
