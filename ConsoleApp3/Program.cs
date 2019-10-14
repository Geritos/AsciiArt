using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        const int canvasX = 100;
        const int canvasY = 100;
        static void Main(string[] args)
        {
            int[,] canvas = new int[canvasX, canvasY];
            Console.WriteLine("Zadej souradnice bodu x1 y1 x2 y2");                          
            GetLineCords(Console.ReadLine(), out int x1, out int y1, out int x2, out int y2);
            Console.Clear();
            DrawLine(canvas, x1, y1, x2, y2);
            DrawLineToCanvas(canvas);
            Console.ReadKey();           
        }

        static void GetLineCords(string input, out int x1, out int y1, out int x2, out int y2)
        {            
            var inputTokens = input.Split(' ');
            x1 = int.Parse(inputTokens[0]);
            y1 = int.Parse(inputTokens[1]);
            x2 = int.Parse(inputTokens[2]);
            y2 = int.Parse(inputTokens[3]);
        }            

        static bool DrawLine(int[,] canvas, int x1, int y1, int x2, int y2)
        {        
            int dx12 = x2 - x1;
            int dy12 = y2 - y1;
        
            int steps = Math.Max(Math.Abs(dx12), Math.Abs(dy12));
            double dx = dx12 / (double)steps;
            double dy = dy12 / (double)steps;
        
            for(int i = 0; i <= steps; i++)
            {
                canvas [Convert.ToInt32(x1 + i * dx), Convert.ToInt32(y1 + i * dy)] = 1;
            }       
        return true;
        }

        static void DrawLineToCanvas(int [,] canvas)
        {
            for (int y = 0; y < canvas.GetLength(1); y++)
            {
                for (int x = 0; x < canvas.GetLength(0); x++)
                {
                    Console.Write(canvas[x,y] > 0 ? "█" : "░");
                }          
                Console.WriteLine();
            }
        }
    }
}

