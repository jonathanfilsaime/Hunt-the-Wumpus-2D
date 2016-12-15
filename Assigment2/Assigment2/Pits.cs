using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Pits
    {
        Random rnd = new Random();
        int location;

        public int randomize()
        {
            location = rnd.Next(1, 20);
            Console.WriteLine("pits location: " + location);
            return location;
        }

        private int pitXposition;
        private int pitYposition;

        public void setPitPos(int place)
        {
            if (place == 1)
            {
                pitXposition = 396 - 10;
                pitYposition = 82 - 10;
            }
            if (place == 2)
            {
                pitXposition = 561 - 10;
                pitYposition = 202 - 10;
            }
            if (place == 3)
            {
                pitXposition = 499 - 10;
                pitYposition = 395 - 15;
            }
            if (place == 4)
            {
                pitXposition = 304 - 10;
                pitYposition = 399 - 15;
            }
            if (place == 5)
            {
                pitXposition = 237 - 10;
                pitYposition = 201 - 15;
            }
            if (place == 6)
            {
                pitXposition = 292 - 10;
                pitYposition = 211 - 15;
            }
            if (place == 7)
            {
                pitXposition = 337 - 10;
                pitYposition = 161 - 15;
            }
            if (place == 8)
            {
                pitXposition = 398 - 10;
                pitYposition = 144 - 15;
            }
            if (place == 9)
            {
                pitXposition = 465 - 10;
                pitYposition = 164 - 15;
            }
            if (place == 10)
            {
                pitXposition = 498 - 10;
                pitYposition = 213 - 15;
            }
            if (place == 11)
            {
                pitXposition = 507 - 10;
                pitYposition = 290 - 15;
            }
            if (place == 12)
            {
                pitXposition = 466 - 10;
                pitYposition = 348 - 10;
            }
            if (place == 13)
            {
                pitXposition = 400 - 10;
                pitYposition = 369 - 15;
            }
            if (place == 14)
            {
                pitXposition = 334 - 10;
                pitYposition = 350 - 15;
            }
            if (place == 15)
            {
                pitXposition = 292 - 10;
                pitYposition = 290 - 15;
            }
            if (place == 16)
            {
                pitXposition = 345 - 10;
                pitYposition = 272 - 15;
            }
            if (place == 17)
            {
                pitXposition = 372 - 10;
                pitYposition = 208 - 15;
            }
            if (place == 18)
            {
                pitXposition = 432 - 10;
                pitYposition = 211 - 15;
            }
            if (place == 19)
            {
                pitXposition = 447 - 10;
                pitYposition = 276 - 15;
            }
            if (place == 20)
            {
                pitXposition = 402 - 10;
                pitYposition = 310 - 15;
            }
        }

        public int getPitXPos()
        {
            return pitXposition;
        }

        public int getPitYPos()
        {
            return pitYposition;
        }
    }
}
