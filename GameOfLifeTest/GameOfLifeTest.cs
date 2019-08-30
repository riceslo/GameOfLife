using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeTest
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void CelulaVivaCon2VecinasVivas()

        {   /*Celula Viva con 2 Vecinas Viva, debe devolver como nuevo estado la celula viva */
            CellStatus currentStatus = CellStatus.LIVE;
            int neighborsAlive = 2;

            CellStatus result = RulesGameOfLife.GetNewStatus(currentStatus, neighborsAlive);

             Assert.AreEqual(CellStatus.LIVE, result);
        }
    }
}
