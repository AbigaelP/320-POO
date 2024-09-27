using Drones.Helpers;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet = new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);
            fleet.Add(drone);



            //Création de l'amat de buildings
            List<Building> amat = new List<Building>();
            Building building = new Building();
            amat.Add(building);
            for (int i = 0; i < 5; i++)
            {
                Factory usine = new Factory();
                amat.Add(usine);
            }
            for (int i = 0; i < 5; i++)
            {
                Store magasin = new Store();
                amat.Add(magasin);
            }
            try
            {
                // Démarrage
                Application.Run(new AirSpace(fleet, amat));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
    }
}