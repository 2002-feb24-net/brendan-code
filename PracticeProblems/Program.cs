using System;

namespace PracticeProblems
{
    abstract class Shape
    {
        public abstract int GetArea();
    }
    class Square : Shape
    {
        int side;

        public Square(int n) => side = n;

        public override int GetArea() => side * side;
        static void Main()
        {
            var sq = new Square(12);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");
        }
        
    }
        
    
}
