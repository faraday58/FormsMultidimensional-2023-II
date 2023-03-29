﻿using System;

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

            Multidimensional m1 = new Multidimensional(renglones.Length, columnas.Length);

            for(int i=0; i< m1.M; i++  )
            {
                columnas = renglones[i].Split(',');
                for (int j=0; j < m1.N; j++)
                {
                    m1.A[i, j] =float.Parse (columnas[j]);
                }
            }

            return m1;
        }

        public static Multidimensional operator +(Multidimensional m1, Multidimensional m2 )
        {
            Multidimensional m3 = new Multidimensional(m2.M, m2.N);

            for( int i=0; i< m1.M; i++  )
            {
                for (int j = 0; j < m1.N; j++ )
                {
                    m3.A[i, j] = m1.A[i, j] + m2.A[i, j];
                }
            }

            return m3;
        }



        public override string ToString()
        {
            //1 2 3
            //4 5 6
            string A = "";
            for (int i = 0;  i < M; i++ )
            {
                for (int j=0; j < N; j++)
                {
                    A = A + " " + this.A[i, j].ToString();
                }
                A = A + "\n";
            }
            return A;
        }
    }


}
