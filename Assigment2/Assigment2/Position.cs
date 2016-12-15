using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Position
    {
        private int zeldaXposition;
        private int zeldaYposition;

        public void setZeldaPos(int place)
        {
            if (place == 1)
            {
                zeldaXposition = 396 - 10;
                zeldaYposition = 82 - 10;
            }
            if (place == 2)
            {
                zeldaXposition = 561 - 10;
                zeldaYposition = 202 - 10;
            }
            if (place == 3)
            {
                zeldaXposition = 499 - 10;
                zeldaYposition = 395 - 15;
            }
            if (place == 4)
            {
                zeldaXposition = 304 - 10;
                zeldaYposition = 399 - 15;
            }
            if (place == 5)
            {
                zeldaXposition = 237 - 10;
                zeldaYposition = 201 - 15;
            }
            if (place == 6)
            {
                zeldaXposition = 292 - 10;
                zeldaYposition = 211 - 15;
            }
            if (place == 7)
            {
                zeldaXposition = 337 - 10;
                zeldaYposition = 161 - 15;
            }
            if (place == 8)
            {
                zeldaXposition = 398 - 10;
                zeldaYposition = 144 - 15;
            }
            if (place == 9)
            {
                zeldaXposition = 465 - 10;
                zeldaYposition = 164 - 15;
            }
            if (place == 10)
            {
                zeldaXposition = 498 - 10;
                zeldaYposition = 213 - 15;
            }
            if (place == 11)
            {
                zeldaXposition = 507 - 10;
                zeldaYposition = 290 - 15;
            }
            if (place == 12)
            {
                zeldaXposition = 466 - 10;
                zeldaYposition = 348 - 10;
            }
            if (place == 13)
            {
                zeldaXposition = 400 - 10;
                zeldaYposition = 369 - 15;
            }
            if (place == 14)
            {
                zeldaXposition = 334 - 10;
                zeldaYposition = 350 - 15;
            }
            if (place == 15)
            {
                zeldaXposition = 292 - 10;
                zeldaYposition = 290 - 15;
            }
            if (place == 16)
            {
                zeldaXposition = 345 - 10;
                zeldaYposition = 272 - 15;
            }
            if (place == 17)
            {
                zeldaXposition = 372 - 10;
                zeldaYposition = 208 - 15;
            }
            if (place == 18)
            {
                zeldaXposition = 432 - 10;
                zeldaYposition = 211 - 15;
            }
            if (place == 19)
            {
                zeldaXposition = 447 - 10;
                zeldaYposition = 276 - 15;
            }
            if (place == 20)
            {
                zeldaXposition = 402 - 10;
                zeldaYposition = 310 - 15;
            }
        }

        public int getZeldaXPos()
        {
            return zeldaXposition;
        }

        public int getZeldaYPos()
        {
            return zeldaYposition;
        }

    }
}
