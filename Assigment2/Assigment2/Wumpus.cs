using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Wumpus
    {
        Random rnd = new Random();
        int location;

        private int wumpusXposition;
        private int wumpusYposition;

        public int randomize()
        {
            location = rnd.Next(1, 20);
            location = rnd.Next(1, 20);
            location = rnd.Next(1, 20);
            location = rnd.Next(1, 20);
            Console.WriteLine("wumpus location: " + location);
            return location;
        }


        public void setWumpusPos(int place)
        {
            if (place == 1)
            {
                wumpusXposition = 396 - 30;
                wumpusYposition = 82 - 25;
            }
            if (place == 2)
            {
                wumpusXposition = 561 - 30;
                wumpusYposition = 202 - 25;
            }
            if (place == 3)
            {
                wumpusXposition = 499 - 30;
                wumpusYposition = 395 - 25;
            }
            if (place == 4)
            {
                wumpusXposition = 304 - 30;
                wumpusYposition = 399 - 25;
            }
            if (place == 5)
            {
                wumpusXposition = 237 - 30;
                wumpusYposition = 201 - 25;
            }
            if (place == 6)
            {
                wumpusXposition = 292 - 30;
                wumpusYposition = 211 - 25;
            }
            if (place == 7)
            {
                wumpusXposition = 337 - 30;
                wumpusYposition = 161 - 25;
            }
            if (place == 8)
            {
                wumpusXposition = 398 - 30;
                wumpusYposition = 144 - 25;
            }
            if (place == 9)
            {
                wumpusXposition = 465 - 30;
                wumpusYposition = 164 - 25;
            }
            if (place == 10)
            {
                wumpusXposition = 498 - 30;
                wumpusYposition = 213 - 25;
            }
            if (place == 11)
            {
                wumpusXposition = 507 - 30;
                wumpusYposition = 290 - 25;
            }
            if (place == 12)
            {
                wumpusXposition = 466 - 30;
                wumpusYposition = 348 - 20;
            }
            if (place == 13)
            {
                wumpusXposition = 400 - 30;
                wumpusYposition = 369 - 25;
            }
            if (place == 14)
            {
                wumpusXposition = 334 - 30;
                wumpusYposition = 350 - 25;
            }
            if (place == 15)
            {
                wumpusXposition = 292 - 30;
                wumpusYposition = 290 - 25;
            }
            if (place == 16)
            {
                wumpusXposition = 345 - 30;
                wumpusYposition = 272 - 25;
            }
            if (place == 17)
            {
                wumpusXposition = 372 - 30;
                wumpusYposition = 208 - 25;
            }
            if (place == 18)
            {
                wumpusXposition = 432 - 30;
                wumpusYposition = 211 - 25;
            }
            if (place == 19)
            {
                wumpusXposition = 447 - 30;
                wumpusYposition = 276 - 25;
            }
            if (place == 20)
            {
                wumpusXposition = 402 - 30;
                wumpusYposition = 310 - 25;
            }
        }

        public int getWumpusXPos()
        {
            return wumpusXposition;
        }

        public int getWumpusYPos()
        {
            return wumpusYposition;
        }

    }
}
