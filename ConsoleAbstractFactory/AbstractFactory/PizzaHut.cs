namespace AbstractFactory
{
    public class PizzaHut : Restaurante
    {
        public override Lasagna CrearLasagna()
        {
            return new LasagnaPollo();
        }

        public override Pizza CrearPizza()
        {
            return new PizzaPepperoni();
        }
    }
}