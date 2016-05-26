using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verify2
{
    /**
    * Класс для работы с квадратными матрицами
    */
    public class Matrix
    {
        /**
        * Метод для транспонирования квадратной матрицы
        * @param A - исходная матрица (не должна быть равна null, должна быть квадратная)
        * @param n - размерность матрицы (должна быть равна количеству строк и столбцов)
        * @return - транспонированная матрица
        */
        public float[,] TranspositionMatrix(float[,] A, int n)
        {
            float temp;
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                {
                    temp = A[i, j];
                    A[i, j] = A[j, i];
                    A[j, i] = temp;
                }
            return A;
        }

      
    }
}
