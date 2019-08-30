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

        [TestMethod]
        public void CelulaVivaCon3VecinasVivas()

        {   /*Celula Viva con 3 Vecinas Viva, debe devolver como nuevo estado la celula viva */
            CellStatus currentStatus = CellStatus.LIVE;
            int neighborsAlive = 3;

            CellStatus result = RulesGameOfLife.GetNewStatus(currentStatus, neighborsAlive);

            Assert.AreEqual(CellStatus.LIVE, result);
        }

        [TestMethod]
        public void CelulaVivaCon4VecinasVivas()

        {   /*Celula Viva con 4 Vecinas Viva, debe devolver como nuevo estado la celula muerta */
            /* muere de superpoblacion */
            CellStatus currentStatus = CellStatus.LIVE;
            int neighborsAlive = 4;

            CellStatus result = RulesGameOfLife.GetNewStatus(currentStatus, neighborsAlive);

            Assert.AreEqual(CellStatus.DEAD, result);
        }

        [TestMethod]
        public void CelulaVivaCon5VecinasVivas()

        {   /*Celula Viva con 5 Vecinas Viva, debe devolver como nuevo estado la celula muerta */
            /* muere de superpoblacion */
            CellStatus currentStatus = CellStatus.LIVE;
            int neighborsAlive = 5;

            CellStatus result = RulesGameOfLife.GetNewStatus(currentStatus, neighborsAlive);

            Assert.AreEqual(CellStatus.DEAD, result);
        }

        [TestMethod]
        public void CelulaVivaCon1VecinasVivas()

        {   /*Celula Viva con 1 Vecinas Viva, debe devolver como nuevo estado la celula muerta */
            /* muere de soledad */
            CellStatus currentStatus = CellStatus.LIVE;
            int neighborsAlive = 1;

            CellStatus result = RulesGameOfLife.GetNewStatus(currentStatus, neighborsAlive);

            Assert.AreEqual(CellStatus.DEAD, result);
        }

        [TestMethod]
        public void CelulaMuertaCon1VecinasViva()

        {   /*Celula Muerta con 1 Vecinas Viva, debe devolver como nuevo estado la celula muerta */
            
            CellStatus currentStatus = CellStatus.DEAD;
            int neighborsAlive = 1;

            CellStatus result = RulesGameOfLife.GetNewStatus(currentStatus, neighborsAlive);

            Assert.AreEqual(CellStatus.DEAD, result);
        }

        [TestMethod]
        public void CelulaMuertaCon2VecinasViva()

        {   /*Celula Muerta con 2 Vecinas Viva, debe devolver como nuevo estado la celula muerta */

            CellStatus currentStatus = CellStatus.DEAD;
            int neighborsAlive = 2;

            CellStatus result = RulesGameOfLife.GetNewStatus(currentStatus, neighborsAlive);

            Assert.AreEqual(CellStatus.DEAD, result);
        }

        [TestMethod]
        public void CelulaMuertaCon3VecinasViva()

        {   /*Celula Muerta con 3 Vecinas Viva, debe devolver como nuevo estado la celula viva */

            CellStatus currentStatus = CellStatus.DEAD;
            int neighborsAlive = 3;

            CellStatus result = RulesGameOfLife.GetNewStatus(currentStatus, neighborsAlive);

            Assert.AreEqual(CellStatus.LIVE, result);
        }
    }
}
