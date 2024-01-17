using Polimorfismo_Herencia;

internal class Program
{
    private static void Main(string[] args)
    {
        //Instanciamos las clases derivadas
        Vehiculo automovil = new Coche("Gasolina","Mitsubishi","Lancer",2007);
        Vehiculo motocicleta = new Moto("KTM","RC390",2017);

        //Se utiliza polimorfismo para llamar al metodo abstracto Conducir()
        ConducirVehiculo(automovil);
        ConducirVehiculo(motocicleta);

    }

    static void ConducirVehiculo(Vehiculo vehiculo)
    {
        vehiculo.MostrarInformacion();
        vehiculo.Conducir();
        Console.WriteLine();
    }
}