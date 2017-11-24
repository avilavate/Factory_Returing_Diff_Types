using Factory_Returing_Diff_Types.Types;

namespace Factory_Returing_Diff_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Option 1
            IElectronics myElectroninc = ElectronicsFactory.Factory<TV>();

            (myElectroninc as TV).Play();

            //Option 2 When you dont want to expose types in client code.
            (ElectronicsFactory.Factory("Radio") as Radio).Tune();

        }
    }
}
