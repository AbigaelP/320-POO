using Drones.Model;
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
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            //Création de l'amat de buildings
            List<Building> amat = new List<Building>();
            Building building = new Building();
            building.X = Helper.Random(0,AirSpace.WIDTH);
            building.Y = Helper.Random(0,AirSpace.HEIGHT);
            amat.Add(building);

            // Démarrage
            Application.Run(new AirSpace(fleet, amat));
        }
    }
}