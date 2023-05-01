namespace task1_Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///-------------------2--------------
            Point3D p = new() { XPos=10 , YPos=10 , ZPos=10}; 
            Console.WriteLine(p);
            Console.WriteLine((string)p);

            ///-------------------3--------------
     
            //-------------Try Parsing--------------
            double xPos1, yPos1, zPos1, xPos2, yPos2, zPos2;

         
            do { Console.WriteLine("Please enter the x coordinate of first point"); } while (double.TryParse(Console.ReadLine(),out xPos1)==false );
            do { Console.WriteLine("Please enter the y coordinate of first point"); } while (double.TryParse(Console.ReadLine(), out yPos1) == false);
            do { Console.WriteLine("Please enter the z coordinate of first point"); } while (double.TryParse(Console.ReadLine(), out zPos1) == false);

     
            do { Console.WriteLine("Please enter the x coordinate of second point"); } while (double.TryParse(Console.ReadLine(), out xPos2) == false);
            do { Console.WriteLine("Please enter the y coordinate of first point"); } while (double.TryParse(Console.ReadLine(), out yPos2) == false);
            do { Console.WriteLine("Please enter the z coordinate of first point"); } while (double.TryParse(Console.ReadLine(), out zPos2) == false);

            Point3D p1 = new() { XPos=xPos1, YPos = yPos1, ZPos = zPos1 };
            Point3D p2 = new() { XPos = xPos2, YPos = yPos2, ZPos = zPos2 };

            Console.WriteLine(p1);
            Console.WriteLine(p2);
     

            //== without operator overriding Doesn't work properly
            if (p1==p2)
            {
                Console.WriteLine("True"); 
            }
            else Console.WriteLine("False");

        }

        class Point3D 
        {
            public double XPos { get; set; } 
            public double YPos { get; set; }    
            public double ZPos { get; set; }

            //public Point3D(double xPos, double yPos, double zPos)
            //{
            //    XPos = xPos;
            //    YPos = yPos;
            //    ZPos = zPos;
            //}
            public override string ToString()
            {
                return $"Point Coordinates: ({XPos},{YPos},{ZPos})";
            }

            public static bool operator == (Point3D p1, Point3D p2)
            {
                if(p1.XPos == p2.XPos && p1.YPos == p2.YPos&& p1.ZPos == p2.ZPos)
                {
                    return true ;
                }
                return false;
            }

            public static bool operator !=(Point3D p1, Point3D p2)
            {
                return (p1.XPos != p2.XPos || p1.YPos != p2.YPos || p1.ZPos != p2.ZPos); 

            }

            public static explicit operator string(Point3D p)
            {
                return p.ToString();
            }

        }

    }
}