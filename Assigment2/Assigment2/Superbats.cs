using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Superbats
    {
        Random rnd = new Random();
        int location;

        public int randomize()
        {
            location = rnd.Next(1, 20);
            location = rnd.Next(1, 20);
            Console.WriteLine("superbats location: " + location);
            return location;
        }

        private int superBatsXposition;
        private int superBatsYposition;

        public void setsuperBatsPos(int place)
        {
            if (place == 1)
            {
                superBatsXposition = 396 - 10;
                superBatsYposition = 82 - 10;
            }
            if (place == 2)
            {
                superBatsXposition = 561 - 10;
                superBatsYposition = 202 - 10;
            }
            if (place == 3)
            {
                superBatsXposition = 499 - 10;
                superBatsYposition = 395 - 15;
            }
            if (place == 4)
            {
                superBatsXposition = 304 - 10;
                superBatsYposition = 399 - 15;
            }
            if (place == 5)
            {
                superBatsXposition = 237 - 10;
                superBatsYposition = 201 - 15;
            }
            if (place == 6)
            {
                superBatsXposition = 292 - 10;
                superBatsYposition = 211 - 15;
            }
            if (place == 7)
            {
                superBatsXposition = 337 - 10;
                superBatsYposition = 161 - 15;
            }
            if (place == 8)
            {
                superBatsXposition = 398 - 10;
                superBatsYposition = 144 - 15;
            }
            if (place == 9)
            {
                superBatsXposition = 465 - 10;
                superBatsYposition = 164 - 15;
            }
            if (place == 10)
            {
                superBatsXposition = 498 - 10;
                superBatsYposition = 213 - 15;
            }
            if (place == 11)
            {
                superBatsXposition = 507 - 10;
                superBatsYposition = 290 - 15;
            }
            if (place == 12)
            {
                superBatsXposition = 466 - 10;
                superBatsYposition = 348 - 10;
            }
            if (place == 13)
            {
                superBatsXposition = 400 - 10;
                superBatsYposition = 369 - 15;
            }
            if (place == 14)
            {
                superBatsXposition = 334 - 10;
                superBatsYposition = 350 - 15;
            }
            if (place == 15)
            {
                superBatsXposition = 292 - 10;
                superBatsYposition = 290 - 15;
            }
            if (place == 16)
            {
                superBatsXposition = 345 - 10;
                superBatsYposition = 272 - 15;
            }
            if (place == 17)
            {
                superBatsXposition = 372 - 10;
                superBatsYposition = 208 - 15;
            }
            if (place == 18)
            {
                superBatsXposition = 432 - 10;
                superBatsYposition = 211 - 15;
            }
            if (place == 19)
            {
                superBatsXposition = 447 - 10;
                superBatsYposition = 276 - 15;
            }
            if (place == 20)
            {
                superBatsXposition = 402 - 10;
                superBatsYposition = 310 - 15;
            }
        }

        public int getsuperBatsXPos()
        {
            return superBatsXposition;
        }

        public int getsuperBatsYPos()
        {
            return superBatsYposition;
        }
    }
}
