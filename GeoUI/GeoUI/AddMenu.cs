using GeoLib;

namespace GeoUI
{
    internal static class AddMenu
    {
        public static void RenderMenu(List<Shape> list)
        {
            int option;
            string? input;

            do
            {
                Console.Clear();
                Console.WriteLine("AGREGAR FORMA");
                Console.WriteLine("=============");
                Console.WriteLine();

                Console.WriteLine("1- Cuadrado");
                Console.WriteLine("2- Rectangulo");
                Console.WriteLine("0- Regresar");

                input = Console.ReadLine();

                if (!int.TryParse(input, out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1:
                        if (RenderSquareSubmenu(list))
                        {
                            Console.WriteLine("Cuadrado agregado. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        if (RenderRectangleSubmenu(list))
                        {
                            Console.WriteLine("Rectangulo agregado. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                }
            } while (option != 0);
        }

        private static bool RenderSquareSubmenu(List<Shape> list)
        {
            float side;
            string? input;

            Console.Clear();
            Console.WriteLine("AGREGAR CUADRADO");
            Console.WriteLine("================");
            Console.WriteLine();

            Console.Write("Lado (cm): ");
            input= Console.ReadLine();

            if (!float.TryParse(input, out side))
            {
                Console.WriteLine("Valor no valido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (side <= 0)
            {
                Console.WriteLine("Lado debe ser mayor a 0. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            list.Add(new Square(side));
            return true;
        }

        private static bool RenderRectangleSubmenu(List<Shape> list)
        {
            float bas;
            float height;
            string? input;

            Console.Clear();
            Console.WriteLine("AGREGAR RECTANGULO");
            Console.WriteLine("==================");
            Console.WriteLine();

            Console.Write("Base (cm): ");
            input = Console.ReadLine();

            if(!float.TryParse(input,out bas))
            {
                Console.WriteLine("Valor no valido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (bas <= 0)
            {
                Console.WriteLine("Base debe ser mayor a 0. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            Console.Write("Altura (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse (input,out height))
            {
                Console.WriteLine("Valor no valido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (height <= 0)
            {
                Console.WriteLine("Altura debe ser mayor a 0. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (bas == height)
            {
                Console.WriteLine("Base y Altura no deben ser iguales. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            list.Add(new Rectangle(bas, height));
            return true;    
        }

    }
}
