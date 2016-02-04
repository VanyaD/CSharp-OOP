using System;

namespace Matrix_Problems_8910_
{
    public class Matrix<T> where T : IComparable
    {
        private int width;
        private int height;
        private T[,] matrix;

        public Matrix(int width, int height)
        {
            this.matrix = new T[width, height];
            this.Width = width;
            this.Height = height;
        }

        public Matrix(int size)
        {
            this.matrix = new T[width, height];
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

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Width) ||
                    (col < 0 || col >= this.Height))
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Width) ||
                    (col < 0 || col >= this.Height))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
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
            if (m1.Height != m2.Width)
            {
                throw new Exception("These matrices cannot be multiplied.");
            }

            Matrix<T> result = new Matrix<T>(m1.Height, m2.Width);
            T temp;

            for (int matrixRow = 0; matrixRow < result.Height; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < result.Width; matrixCol++)
                {
                    temp = (dynamic)0;
                    for (int index = 0; index < result.Width; index++)
                    {
                        temp += (dynamic)m1[matrixRow, index] * m2[index, matrixCol];
                    }
                    result[matrixRow, matrixCol] = (dynamic)temp;
                }
            }

            return result;
        }
    }
}
