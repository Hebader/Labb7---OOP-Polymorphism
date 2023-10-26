using System.Threading.Channels;

namespace Labb7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Cirkel cirkel = new Cirkel(); // Anropar klass
            Rektangel rektangel = new Rektangel();
            Fyrkant fyrkant = new Fyrkant();
            Parallellogram parallellogram = new Parallellogram();
            Ellips ellips = new Ellips();

            

            Geometri[] Shapes = {cirkel,rektangel, fyrkant,parallellogram,ellips}; // En array där alla anropade klasser sätts in
            foreach (Geometri shape in Shapes) // Gör en foreaach för att få en utrskift av alla uträkningar av formarna
            {
                // skapar en double som sparar uträkningarna av varje form
                double area = shape.Area(); // räknar ut arean av varje form i metoden "Area"
                Console.WriteLine($"Area {shape.GetType().Name}: {area}"); // Utskrift

            }
           
        }
    }

    public class Geometri  //Skapar en parentclass
    {
    public virtual double Area() // Gör metoden virutal för att kunna overrida/ändra i andra klasser
        {

            return 0.0;    // Standardvärde
        }
    }
    public class Rektangel: Geometri //Rektangel ärver från Geomoteri
    {
        public double Lenght { get; set; }  // skapar egenskapen Lenght 
        public double Widht { get; set; } //skapar egenskpaen Widht

        public Rektangel() // Konstruktor
        {
            Lenght = 4; // Sätter ett fast värde
            Widht = 6;  
        }

        public override double Area() // Överför metod från parentsclass
        {
            return Lenght * Widht; // Ändrar typen av beräkningnen
            

        }

    }
    public class Fyrkant : Geometri // Fyrkant ärver från Geometri
    {
        public double Side { get; set; }  // Skapar en egenskap, en sida då det är en kvadrat

        public Fyrkant() //Kostruktor
        {
            Side = 5; // Sätter ett fast värde
        }

        public override double Area() // Överför metod
        {
            double area = 5 * 5; // Bestämmer typ av beräkning
            return area; // retunerar arean
         
        }
    }
    public class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel ()   
        {

          Radius = 4;
        }

        public override double Area()
        {
           double _pi = 3.141; // skapar en variabel för "pi"
           double area = 4 * 4 * _pi; // skapar en varibel för area
           return area; 

        }
    }
    public class Parallellogram : Geometri
    {
        public double Height { get; set; }  
        public double Base { get; set; }

        public Parallellogram() 
        {
            Height = 4;
            Base = 5;
        }
        public override double Area()
        {
           double area = 4 * 5;
            return area;
        }
    }
    public class Ellips : Geometri
    {
        public double a { get; set; }
        public double b { get; set; }   

        public Ellips() 
        {
            a = 7;
            b = 9;
        }

        public override double Area()
        {
            double _pi = 3.141f;
            double area = a * b * _pi;
            return area;

        } 

    }
}