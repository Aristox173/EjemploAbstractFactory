namespace AbstractFactory
{
    public class PapaJohns : Restaurante
    {
        public override Lasagna CrearLasagna()
        {
            return new LasagnaCarne();
        }

        public override Pizza CrearPizza()
        {
            return new PizzaJamon();
        }
    }
}