using System.Threading.Channels;

namespace Labb7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Cirkel cirkel = new Cirkel(); // anropar objekt från klass
            Rektangel rektangel = new Rektangel();
            Fyrkant fyrkant = new Fyrkant();
            Parallellogram parallellogram = new Parallellogram();
            Ellips ellips = new Ellips();

           
            Geometri[] Shapes = {cirkel,rektangel, fyrkant,parallellogram,ellips}; // En array där alla anropade objekt sätts in
            foreach (Geometri shape in Shapes) // Gör en foreaach för att få en utrskift av alla uträkningar av formarna/objekten
            {
                // skapar en double som sparar uträkningarna av varje form
                double area = shape.Area(); // räknar ut arean av varje form i metoden "Area"
                Console.WriteLine($"Area {shape.GetType().Name}: {area}"); // Utskrift, får fram varje forms namn med " GetType().name"

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

        public Cirkel ()   // Tom konstruktor för att sätta ett fast värde för Radius
        {

          Radius = 4; // fast värde
        }

        public override double Area()
        {
           double _pi = 3.141; // skapar en variabel för värdet på "pi"
           double area = 4 * 4 * _pi; // skapar en varibel för area och räknar ut arean
           return area; // retunerar arean

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
        public double side1 { get; set; }
        public double side2 { get; set; }   

        public Ellips() 
        {
            side1= 7;
            side2 = 9;
        }

        public override double Area()
        {
            double _pi = 3.141f;
            double area = side1 * side2 * _pi;
            return area;

        } 

    }
}