using Factory_Returing_Diff_Types.Types;

namespace Factory_Returing_Diff_Types
{
    public class ElectronicsFactory
    {
        public static T Factory<T>() where T : IElectronics, new()
        {
            return new T();
        }

        public static IElectronics Factory(string electronicsType)
        {
            switch (electronicsType)
            {
                case "TV": return ElectronicsFactory.Factory<TV>();
                case "Radio": return ElectronicsFactory.Factory<Radio>();
                default:
                    return ElectronicsFactory.Factory<NotElectronic>();
            }
        }

    }
}