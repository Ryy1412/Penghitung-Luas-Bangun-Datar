using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penghitung_luas_bangun_datar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            while (true)
            {
                Console.WriteLine("\nPenghitung Luas Bangun Datar");
                Console.WriteLine("\nSilahkan Masukkan Pilihan Anda :");
                Console.WriteLine("1. Add Persegi");
                Console.WriteLine("2. Add Persegi Panjang");
                Console.WriteLine("3. Add Lingkaran");
                Console.WriteLine("4. Add Segitiga");
                Console.WriteLine("5. Exit");
                Console.Write("Pilih option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddSquare(shapes);
                        break;
                    case 2:
                        AddRectangle(shapes);
                        break;
                    case 3:
                        AddCircle(shapes);
                        break;
                    case 4:
                        AddTriangle(shapes);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Tidak ada cuy, ulangi ya !.");
                        break;
                }
            }
        }
        private static void AddSquare(List<Shape> shapes)
        {
            Console.WriteLine("Persegi");
            Console.Write("Masukkan sisi : ");
            double side = double.Parse(Console.ReadLine());

            Square square = new Square(side);
            shapes.Add(square);
            Console.WriteLine($"Luas persegi : {square.CalculateArea()}");
        }

        private static void AddRectangle(List<Shape> shapes)
        {
            Console.WriteLine("Persegi Panjang");
            Console.Write("Panjang : ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Lebar : ");
            double width = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, width);
            shapes.Add(rectangle);
            Console.WriteLine($"Luas persegi panjang : {rectangle.CalculateArea()}");
        }

        private static void AddCircle(List<Shape> shapes)
        {
            Console.WriteLine("Lingkaran");
            Console.Write("Jari Jari : ");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);
            shapes.Add(circle);
            Console.WriteLine($"Luas lingkaran : {circle.CalculateArea()}");
        }

        private static void AddTriangle(List<Shape> shapes)
        {
            Console.WriteLine("Segitiga");
            Console.Write("Alas : ");
            double @base = double.Parse(Console.ReadLine());
            Console.Write("Tinggi : ");
            double height = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(@base, height);
            shapes.Add(triangle);
            Console.WriteLine($"Luas segitiga : {triangle.CalculateArea()}");

        }
    }
}
