using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Problems_8910_
{
    public class Matrix<T> where T : IComparable
    {
        private int width;
        private int height;
        private T[,] items;

        public Matrix(int width, int height)
        {
            this.Items = new T[width, height];
            this.Width = width;
            this.Height = height;
        }
        public Matrix(int size)
        {
            this.Items = new T[width, height];
            this.Width = size;
            this.Height = size;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be less or equal to zero");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less or equal to zero");
                }
                this.height = value;
            }
        }

        public T[,] Items
        {
            get
            {
                return this.items;
            }
            private set
            {
                this.items = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.items[row, col];
            }
            private set
            {
                this.items[row, col] = value;
            }
        }

        
        public static Matrix<T> operator+(Matrix<T> m1, Matrix<T> m2)
        {
           Matrix<T> result = new Matrix<T>(m1.width, m1.height);

           for (int row = 0; row < result.height; row++)
           {
               for (int col = 0; col < result.width; col++)
               {
                   result[row, col] = (dynamic)m1[row, col] + m2[row, col];
               }
           }
           return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>(m1.width, m1.height);

            for (int row = 0; row < result.height; row++)
            {
                for (int col = 0; col < result.width; col++)
                {
                    result[row, col] = (dynamic)m1[row, col] - m2[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>(m1.width, m1.height);

            for (int row = 0; row < result.height; row++)
            {
                for (int col = 0; col < result.width; col++)
                {
                    result[row, col] = (dynamic)m1[row, col] * m2[row, col];
                }
            }
            return result;
        }
    }
}
