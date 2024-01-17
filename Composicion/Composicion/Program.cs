using Composicion;

internal class Program
{
    private static void Main(string[] args)
    {
        Coche cocheSinControlCrucero = new Coche(new Acelerador());
        Coche cocheConControlCrucero = new Coche(new ControlCrucero());

        cocheSinControlCrucero.Arrancar();
        cocheSinControlCrucero.AumentarVelocidad();

        cocheConControlCrucero.Arrancar();
        cocheConControlCrucero.AumentarVelocidad();
        
    }
}