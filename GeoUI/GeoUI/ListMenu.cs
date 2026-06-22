using GeoLib;

namespace GeoUI
{
    internal static class ListMenu
    {
        public static void RenderMenu(List<Shape> list)
        {
            int option;
            string? input;

            do
            {
                Console.Clear();
                Console.WriteLine("LISTA DE FORMAS");
                Console.WriteLine("===============");
                Console.WriteLine();

                if (list.Count > 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine((i + 1) + "- " + list[i].Name);
                    }
                }
                else
                {
                    Console.WriteLine("== LISTA VACIA ==");
                }

                Console.WriteLine("0- Regresar");

                input = Console.ReadLine();

                if (!int.TryParse(input, out option))
                {
                    option = -1;
                }

                if (option > 0 && option <= list.Count)
                {
                    RenderShadeSubmenu(list, list[option - 1]);
                }

                else if (option != 0)
                {
                    Console.WriteLine("Opcion no valida. Presione ENTER para continuar...");
                    Console.ReadLine();
                }

            } while (option != 0);
        }

        private static void RenderShadeSubmenu(List<Shape> list, Shape shape)
        {
            int option;
            string? input;

            do
            {
                Console.Clear();
                Console.WriteLine("FORMA: " + shape.Name.ToUpper());
                Console.WriteLine("========" + RenderShapeNameLowerLine(shape.Name.Length));
                Console.WriteLine();

                Console.WriteLine("1- Information");
                Console.WriteLine("2- Borrar");
                Console.WriteLine("0- Regresar");

                input= Console.ReadLine();

                if (!int.TryParse (input, out option))
                {
                    option= -1;
                }

                switch (option)
                {
                    case 1:
                        RenderShapeInformationSubmenu(shape);
                        break;
                    case 2:
                        if (RenderShapeDeleateSubMenu(list, shape))
                        {
                            Console.WriteLine(shape.Name + " removido. Presione ENTER para continuar");
                            Console.ReadLine();
                            option = 0;
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

        private static void RenderShapeInformationSubmenu(Shape shape)
        {
            Console.Clear();
            Console.WriteLine(shape.Render());
            Console.WriteLine("Area: " + shape.GetArea());
            Console.WriteLine("Perimetro: " + shape.GetPerimeter());
            Console.WriteLine("Presione ENTER para regresar...");
            Console.ReadLine();

        }

        private static bool RenderShapeDeleateSubMenu(List<Shape> list, Shape shape)
        {
            string? input;

            do
            {
                Console.Clear();
                Console.WriteLine("Esta seguro que desea borrar esta forma? S/N");

                input = Console.ReadLine()?.ToLower();

                switch (input)
                {
                    case "s":
                    case "si":
                    case "sí":
                        list.Remove(shape);
                        return true;
                    case "n":
                    case "no":
                        return false;
                    default:
                        Console.WriteLine("Opcion no valida. Presione ENTER para continuar...");
                        break;
                }

            } while (true);
        }

        private static string RenderShapeNameLowerLine(int size)
        {
            string render = "";

            for (int i = 0; i < size - 1; i++)
            {
                render += "=";
            }

            return render;
        }
    }
}
