using System;

namespace Lab_3
{
    internal class Program
    {
        private static Vector2D previousVector2D = new Vector2D();
        private static Vector2D currentVector2D = new Vector2D();

        private static Vector3D previousVector3D = new Vector3D();
        private static Vector3D currentVector3D = new Vector3D();

        private static bool adding = false;
        private static bool dotInProccess = false;
        private static bool is2D = true;


        public static void Main(string[] args)
        {
            showMenu();
        }

        static void showMenu()
        {
            Console.WriteLine("\n\nOptions Menu:");
            if (adding)
            {
                Console.WriteLine("---Adding---");
            }
            else if (dotInProccess)
            {
                Console.WriteLine("---Dot product---");
            }

            Console.WriteLine("1-Create vector");
            Console.WriteLine("2-Show vector");
            Console.WriteLine("3-Get vector length");
            if (adding || dotInProccess)
            {
                Console.WriteLine("4-Multiply vector by number");
            }
            else
            {
                Console.WriteLine("4-Add vectors");
                Console.WriteLine("5-Dot product");
                Console.WriteLine("6-Multiply vector by number");
            }

            if (!(adding || dotInProccess))
            {
                if (is2D)
                {
                    Console.WriteLine("/-Switch to 3d");
                }
                else
                {
                    Console.WriteLine("/-Switch to 2d");
                }
            }

            if (adding || dotInProccess)
            {
                Console.WriteLine("= Get result");
            }
            


            string options = Console.ReadLine().ToString();
            switch (options)
            {
                case "1":
                    Console.WriteLine("Enter x coordianate:");
                    double x = double.Parse(Console.ReadLine().ToString());
                    
                    Console.WriteLine("Enter y coordianate:");
                    double y = double.Parse(Console.ReadLine().ToString());

                    if (!is2D)
                    {
                        Console.WriteLine("Enter z coordianate:");
                        double z = double.Parse(Console.ReadLine().ToString());
                        currentVector3D = new Vector3D(x, y, z);
                        
                        showMenu();
                    }

                    currentVector2D = new Vector2D(x, y);

                    showMenu();
                    break;
                case "2":
                    if (is2D)
                    {
                        Console.WriteLine("Current vector is x: " + currentVector2D.x + ", y:" + currentVector2D.y);
                    }
                    else
                    {
                        Console.WriteLine("Current vector is x: " + currentVector3D.x + ", y:" + currentVector3D.y + ", z:" + currentVector3D.z);
                    }

                    showMenu();
                    
                    break;
                case "3":
                    if (is2D)
                    {
                        Console.WriteLine("Current vector length is " + currentVector2D.getLenght());
                    }
                    else
                    {
                        Console.WriteLine("Current vector length is " + currentVector3D.getLenght());
                    }

                    showMenu();
                    break;
                case "4":
                    if (adding)
                    {
                        Console.WriteLine("Enter vector multiplier:");
                        double multiplier = double.Parse(Console.ReadLine().ToString());

                        if (!is2D)
                        {
                            currentVector3D = currentVector3D.Multiply(multiplier) as Vector3D; 
                            Console.WriteLine("\nMultiplied!\n");

                            showMenu();
                        }
                        else
                        {
                            currentVector2D = currentVector2D.Multiply(multiplier) as Vector2D; 
                            Console.WriteLine("\nMultiplied!\n");

                            showMenu();
                        }
                    }
                    else
                    {
                        adding = true;

                        if (is2D)
                        {
                            previousVector2D = currentVector2D;
                            currentVector2D = new Vector2D();
                        }
                        else
                        {
                            previousVector3D = currentVector3D;
                            currentVector3D = new Vector3D();
                        }
                    }
                    
                    showMenu();
                    break;
                case "5":
                    if (!dotInProccess)
                    {
                        dotInProccess = true;
                        
                        if (is2D)
                        {
                            previousVector2D = currentVector2D;
                            currentVector2D = new Vector2D();
                        }
                        else
                        {
                            previousVector3D = currentVector3D;
                            currentVector3D = new Vector3D();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice!");

                    }

                    showMenu();
                    break;
                case "6":
                    Console.WriteLine("Enter vector multiplier:");
                    double multiplier2 = double.Parse(Console.ReadLine().ToString());

                    if (!is2D)
                    {
                        currentVector3D = currentVector3D.Multiply(multiplier2) as Vector3D; 
                        Console.WriteLine("\nMultiplied!\n");

                    }
                    else
                    {
                        currentVector2D = currentVector2D.Multiply(multiplier2) as Vector2D; 
                        Console.WriteLine("\nMultiplied!\n");

                    }
                    
                    showMenu();

                    break;
                case "/":
                    if (adding || dotInProccess)
                    {
                        Console.WriteLine("Wrong choice!");
                        showMenu();
                        return;
                        
                    }

                    Console.WriteLine("Now you are using ");

                    if (is2D)
                    {
                        Console.Write("3D");
                        is2D = false;
                    }
                    else
                    {
                        Console.Write("2D");
                        is2D = true;

                    }
                    showMenu();

                    break;

                case "=":
                    if (!(adding || dotInProccess))
                    {
                        Console.WriteLine("Wrong choice!");
                        showMenu();
                        return;
                    }

                    if (adding)
                    {
                        if (is2D)
                        {
                            currentVector2D = currentVector2D.Add(previousVector2D) as Vector2D;
                        }
                        else
                        {
                            currentVector3D = currentVector3D.Add(previousVector3D) as Vector3D;
                        }
                        
                        Console.WriteLine("Successfully added two vectors!");
                    } else if (dotInProccess)
                    {
                        if (is2D)
                        {
                            double dotResult2D = currentVector2D.Scalar(previousVector2D);
                            Console.WriteLine("Dot product is: " + dotResult2D);
                        }
                        else
                        {
                            double dotResult3D = currentVector3D.Scalar(previousVector3D);
                            Console.WriteLine("Dot product is: " + dotResult3D);
                        }
                    }
                    
                    adding = false;
                    dotInProccess = false;
                    
                    showMenu();
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    showMenu();
                    break;
            }
        }
    }

    public interface IVector
    {
        double getLenght();
        
        IVector Add(IVector other);
        IVector Multiply(double number);
        double Scalar(IVector other);
    }

    class Vector2D : IVector
    {
        public double x;
        public double y;


        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2D()
        {
            this.x = 0;
            this.y = 0;
        }

        public double getLenght()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public IVector Add(IVector other)
        {
            var vector = other as Vector2D;
            if (vector == null) throw new ArgumentException("The argument must be a Vector2D");
            return new Vector2D(this.x + vector.x, this.y + vector.y);
        }

        public IVector Multiply(double number)
        {
            return new Vector2D(this.x * number, this.y * number);
        }

        public double Scalar(IVector other)
        {
            var vector = other as Vector2D;
            if (vector == null) throw new ArgumentException("The argument must be a Vector2D");
            return (this.x * vector.x + this.y * vector.y);
        }
    }

    class Vector3D : IVector
    {
        public double x;
        public double y;
        public double z;

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public double getLenght()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public IVector Add(IVector other)
        {
            var vector = other as Vector3D;
            if (vector == null) throw new ArgumentException("The argument must be a Vector3D");
            return new Vector3D(this.x + vector.x, this.y + vector.y, this.z + vector.z);
        }

        public IVector Multiply(double number)
        {
            return new Vector3D(this.x * number, this.y * number, this.z * number);
        }

        public double Scalar(IVector other)
        {
            var vector = other as Vector3D;
            if (vector == null) throw new ArgumentException("The argument must be a Vector3D");
            return (this.x * vector.x + this.y * vector.y + this.z * vector.z);
        }
    }
}