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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

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

            Console.ReadLine();
        }
    }   
}
