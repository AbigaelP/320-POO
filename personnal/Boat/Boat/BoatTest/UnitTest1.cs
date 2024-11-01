using Boat.Model;

namespace BoatTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AjoutContainer()
        {
            //Arrange
            Bateau boat = new Bateau();
            Fridge container1 = new Fridge(20);
            RadioActive container2 = new RadioActive(47);
            //Act
            /*Assert
            Assert.AreEqual(0, boat.flotte.Count());
            Assert.IsTrue(boat.Load(container1));
            Assert.IsTrue(boat.Unload(container1));
            Assert.IsFalse(boat.Unload(container2));*/

            
        }
    }
}