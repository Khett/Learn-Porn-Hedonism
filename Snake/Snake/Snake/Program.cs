using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorisontalLine h1 = new HorisontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Drow();
            }
       }

        static void Draw(Figure figure)
        {
            figure.Drow();
        }



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
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }   
}
