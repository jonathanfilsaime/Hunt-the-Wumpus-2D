using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Arrow
    {
        private int arrowXposition;
        private int arrowYposition;

        public void setarrowPos(int place)
        {

            if (place == 1)
            {
                arrowXposition = 396 - 30;
                arrowYposition = 82 - 10;
            }
            if (place == 2)
            {
                arrowXposition = 561 - 30;
                arrowYposition = 202 - 10;
            }
            if (place == 3)
            {
                arrowXposition = 499 - 30;
                arrowYposition = 395 - 15;
            }
            if (place == 4)
            {
                arrowXposition = 304 - 30;
                arrowYposition = 399 - 15;
            }
            if (place == 5)
            {
                arrowXposition = 237 - 30;
                arrowYposition = 201 - 15;
            }
            if (place == 6)
            {
                arrowXposition = 292 - 30;
                arrowYposition = 211 - 15;
            }
            if (place == 7)
            {
                arrowXposition = 337 - 30;
                arrowYposition = 161 - 15;
            }
            if (place == 8)
            {
                arrowXposition = 398 - 30;
                arrowYposition = 144 - 15;
            }
            if (place == 9)
            {
                arrowXposition = 465 - 30;
                arrowYposition = 164 - 15;
            }
            if (place == 10)
            {
                arrowXposition = 498 - 30;
                arrowYposition = 213 - 15;
            }
            if (place == 11)
            {
                arrowXposition = 507 - 30;
                arrowYposition = 290 - 15;
            }
            if (place == 12)
            {
                arrowXposition = 466 - 30;
                arrowYposition = 348 - 10;
            }
            if (place == 13)
            {
                arrowXposition = 400 - 30;
                arrowYposition = 369 - 15;
            }
            if (place == 14)
            {
                arrowXposition = 334 - 30;
                arrowYposition = 350 - 15;
            }
            if (place == 15)
            {
                arrowXposition = 292 - 30;
                arrowYposition = 290 - 15;
            }
            if (place == 16)
            {
                arrowXposition = 345 - 30;
                arrowYposition = 272 - 15;
            }
            if (place == 17)
            {
                arrowXposition = 372 - 30;
                arrowYposition = 208 - 15;
            }
            if (place == 18)
            {
                arrowXposition = 432 - 30;
                arrowYposition = 211 - 15;
            }
            if (place == 19)
            {
                arrowXposition = 447 - 30;
                arrowYposition = 276 - 15;
            }
            if (place == 20)
            {
                arrowXposition = 402 - 30;
                arrowYposition = 310 - 15;
            }
        }

        public int getarrowXPos()
        {
            return arrowXposition;
        }

        public int getarrowYPos()
        {
            return arrowYposition;
        }
    }
}
