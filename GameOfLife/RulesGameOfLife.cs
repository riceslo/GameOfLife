using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{

    public enum CellStatus
    {
        LIVE = 1,
        DEAD = 0

    }

    public class RulesGameOfLife
    {

        //  REGLLAS
        //  1 PARA QUE UNA CELULA SIGA VIVA, TIENE QUE TENER 2 O 3 VECINAS.SI TIENE MAS MUERE DE SUPER POBLACION.SI TIENE MENOS, MUERE DE SOLEDAD
        //  2 SI UNA CELULA ESTA MUERTA Y TIENE 3 VECINAS VIVAS REVIVE.
        

        public static CellStatus GetNewStatus(CellStatus currentStatus, int neighborsAlive) {
            CellStatus result = currentStatus;
              
            if (currentStatus == CellStatus.LIVE && neighborsAlive >= 2 && neighborsAlive <= 3) {
                result = CellStatus.LIVE;
            }

            if (currentStatus == CellStatus.LIVE && neighborsAlive > 3) {
                result = CellStatus.DEAD;
            }

            if (currentStatus == CellStatus.LIVE && neighborsAlive <= 1)
            {
                result = CellStatus.DEAD;
            }

            return result;
        }



    }
}
