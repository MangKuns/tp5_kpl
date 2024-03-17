// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{

    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
    static void Main(string[] args)
    {

        HaloGeneric halo = new HaloGeneric();

        halo.SapaUser("Rizky Kusuma Nugraha");

    }

}

