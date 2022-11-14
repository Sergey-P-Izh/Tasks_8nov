namespace Spiralel
{
    class Program
    {
        static int [, ] mas;
        static int N;
        static string answer;

        static void Main(string[] args)
        {
            InputTestMatrix();
            SpiralePath();
            WriteAnswer();
        }

        private static void WriteAnswer() 
        {
            Console.WriteLine(answer);
            Console.ReadKey();
        }
        
        private static void SpiralePath()
        {
            int x = 0;
            int y = 0;
            int sx = 1;
            int sy = 0;
            answer = mas [y, x] .ToString();
            int minx = 0;
            int miny = 1;
            int maxx = N - 1;
            int maxy = N - 1;
            bool found;

            do 
            {
               found = false; 
               while ((sx > 0 && x < maxx) ||
                      (sx < 0 && x > minx) ||
                      (sy > 0 && y < maxy) ||
                      (sy < 0 && y > miny))

               
            {
                x += sx;
                y += sy;
                answer +=  " " + mas [y, x];
                found = true;
            }
            if (sx < 0) minx = x+1;
            if (sx > 0) maxx = x-1;
            if (sy < 0) miny = y+1;
            if (sy > 0) maxy = y-1;
            int sx_old = sx;
            sx = -sy;
            sy = sx_old; 
            Console.WriteLine(answer);
            Console.ReadKey();
            } while (true);


        }

        private static bool InRange(int x, int y) 
        {
            if (x < 0 || x >= N) return false;
            if (y < 0 || y >= N) return false;
            if (mas[y, x] == -1) return false;
            return true;
        }

        
        private static void InputTestMatrix()
        {
            N = 5;
            mas = new int [5, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25} };
            
        }
    }
}