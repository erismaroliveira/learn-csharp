using System;

namespace V_Polimorfismo
{
    public abstract class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }


        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public abstract void Area();
    }

    public class Circle : Shape
    {

        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Desenhando um Circulo");
            base.Draw();
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area Circulo " + area);
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Desenhando um Retangulo");
            base.Draw();
        }

        public override void Area()
        {
            int area = Largura * Altura;
            Console.WriteLine("Area Retangulo " + area);
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Desenhando um Triangulo");
            base.Draw();
        }

        public override void Area()
        {
            int area = (Largura * Altura) / 2;
            Console.WriteLine("Area Triangulo " + area);
        }
    }
}
