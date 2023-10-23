namespace Labb7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel rektangel = new Rektangel();
            Cirkel cirkel = new Cirkel();
            Fyrkant fyrkant = new Fyrkant();
            Parallellogram parallellogram = new Parallellogram();
            Ellips ellips = new Ellips();

            Geometri[] geometri = {rektangel,cirkel,fyrkant,parallellogram,ellips };
            foreach (Geometri geometri1 in geometri)
            {
                geometri1.Area();
            }
            
        }
    }

    public class Geometri 
    {
    public virtual void Area()
        {

           
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

        public override void Area()
        {
            double area = 4 * 5;
            Console.WriteLine("Area Rektangel: " + area);

        }

    }
    public class Fyrkant : Geometri
    {
        public double Side { get; set; } 

        public Fyrkant() 
        {
            Side = 5;
        }

        public override void Area()
        {
            double area = 5 * 5;
            Console.WriteLine("Area Fyrkant: " + area);
        }
    }
    public class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel ()   
        {

          Radius = 4;
        }

        public override void Area()
        {
            float _pi = 3.141f;
            double area = 4 * 4 * _pi;
            Console.WriteLine("Area Cirkel: " + area);

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
        public override void Area()
        {
           double area = 4 * 5;
            Console.WriteLine("Area Parallellog: " + area);
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

        public override void Area()
        {
            float _pi = 3.141f;
            double area = a * b * _pi;
            Console.WriteLine("Area Ellips: " + area );

        } 

    }
}