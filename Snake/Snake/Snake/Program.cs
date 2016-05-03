using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.SetBufferSize(80, 25);          //Set window size


            // create frame
            HorisontalLine upline = new HorisontalLine(0, 78, 0, '+' );
            HorisontalLine downline = new HorisontalLine(0, 78, 24, '+' );

            VerticalLine leftline = new VerticalLine(0, 24, 0, '+' );
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+' );

            // paint frame
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            //  Drow point
            Point p = new Point(4, 5, '*');
            //  Make Snake
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }
    }   
}
