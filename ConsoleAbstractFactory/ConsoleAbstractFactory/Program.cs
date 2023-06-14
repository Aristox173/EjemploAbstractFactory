namespace AbstractFactory.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Restaurante fabrica;
            fabrica = new PizzaHut();

            Pizza pizza = fabrica.CrearPizza();
            Lasagna lasagna = fabrica.CrearLasagna();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Lasaña: {lasagna.Descripcion}");

            fabrica = new PapaJohns();
            pizza = fabrica.CrearPizza();
            lasagna = fabrica.CrearLasagna();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Lasaña: {lasagna.Descripcion}");

            Console.ReadKey();

        }
    }
}