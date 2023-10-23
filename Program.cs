using System.Threading.Channels;

namespace Labb7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Cirkel cirkel = new Cirkel();
            Rektangel rektangel = new Rektangel();
            Fyrkant fyrkant = new Fyrkant();
            Parallellogram parallellogram = new Parallellogram();
            Ellips ellips = new Ellips();

            

            Geometri[] geometri = {cirkel,rektangel, fyrkant,parallellogram,ellips };
            foreach (Geometri geometri1 in geometri)
            {
                double area = geometri1.Area();
                Console.WriteLine($"Area {geometri1.GetType().Name}: {area}");

            }
           
        }
    }

    public class Geometri 
    {
    public virtual double Area()
        {

            return 0.0;
    
           
        }
    }
    public class Rektangel: Geometri 
    {
        public double Lenght { get; set; }  
        public double Widht { get; set; }

        public Rektangel()
        {
            Lenght = 4;
            Widht = 6; 
        }

        public override double Area()
        {
            return Lenght * Widht;
            

        }

    }
    public class Fyrkant : Geometri
    {
        public double Side { get; set; } 

        public Fyrkant() 
        {
            Side = 5;
        }

        public override double Area()
        {
            double area = 5 * 5;
            return area;
         
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
           float _pi = 3.141f;
           double area = 4 * 4 * _pi;
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
            float _pi = 3.141f;
            double area = a * b * _pi;
            return area;

        } 

    }
}