using System;

namespace FormsMultidimensional_2023_II
{
    class Multidimensional : Matriz
    {
        private float[,] A;

        public Multidimensional(int M, int N )
        {
            this.M = M;
            this.N = N;
            A = new float[this.M, this.N];
        }

        public static Multidimensional Leer(string A)
        {
            //1,2,3;4,5,6
            string[] renglones = A.Split(';');
            //renglones[0]= {1,2,3};
            //renglones[1]= {4,5,6};
            string[] columnas = renglones[0].Split(',');


        }
    }
}
