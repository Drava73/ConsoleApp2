using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class ClassaArray
    {
        private int[,] array;
        

        public void Point()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,4}", array[i, j]);
                };
            };
        }

        public int Rows
        {
            get;
            private set;
        }
        public int Cols
        {
            get;
            private set;
        }
        public ClassaArray(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new int[rows, cols];
            Random r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(-100, 100);
                    Console.Write("{0,4}", array[i, j]);
                };
            };
        }
       
        public void MaxMin()
        {
            int maxd = 0, mind = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxd <= array[i, j])
                    {
                        maxd = array[i, j];
                    }
                    if (mind >= array[i, j])
                    {
                        mind = array[i, j];
                    }
                };
            };
            Console.Write($"\nMax:{maxd}\nMin:{mind}");
        }
        public int this[int r, int c]
        {
            get
            {
                if (r < 0 || r >= array.GetLength(0))
                {
                    throw new Exception("Некорректный индекс! " + r);
                }
                else if (c < 0 || c >= array.GetLength(1))
                {
                    throw new Exception("Некорректный индекс! " + c);
                }
                else
                    return array[r, c];
            }
            set
            {
                if (r < 0 || r >= array.GetLength(0))
                {
                    throw new Exception("Некорректный индекс! " + r);
                }
                else if (c < 0 || c >= array.GetLength(1))
                {
                    throw new Exception("Некорректный индекс! " + c);
                }
                else
                    array[r, c] = value;
            }
        }
        public static ClassaArray operator +(ClassaArray A, ClassaArray B)
        {
            ClassaArray C = new ClassaArray(A.Rows, A.Cols);
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                for (int i = 0; i < C.Rows; i++)
                {
                    for (int j = 0; j < C.Cols; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }
            }
            return C;
        }
        public static ClassaArray operator -(ClassaArray A, ClassaArray B)
        {
            ClassaArray C = new ClassaArray(A.Rows, A.Cols);
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                for (int i = 0; i < C.Rows; i++)
                {
                    for (int j = 0; j < C.Cols; j++)
                    {
                        C[i, j] = A[i, j] - B[i, j];
                    }
                }
            }
            return C;
        }
        public static ClassaArray operator *(ClassaArray A, ClassaArray B)
        {
            ClassaArray C = new ClassaArray(A.Rows, A.Cols);
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                for (int i = 0; i < C.Rows; i++)
                {
                    for (int j = 0; j < C.Cols; j++)
                    {
                        C[i, j] = A[i, j] * B[i, j];
                    }
                }
            }
            return C;
        }
        public static ClassaArray operator *(ClassaArray A, int number)
        {
            ClassaArray C = new ClassaArray(A.Rows, A.Cols);
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    C[i, j] = A[i, j] * number;
                }
            }
            return C;
        }
        public static bool operator ==(ClassaArray A, ClassaArray B)
        {
            
            
                if (A.Rows != B.Rows || A.Cols != B.Cols) throw new Exception("Rows or columns numbers are different. Comparison error.");
                bool flag = true;
                for (int i = 0; i < A.Rows; i++)
                {
                    for (int j = 0; j < A.Cols; j++)
                    {
                        if (A[i, j] != B[i, j]) return false;
                    }
                }
                return flag;
            }
        public static bool operator !=(ClassaArray A, ClassaArray B)
        {
            
            
                if (A.Rows != B.Rows || A.Cols != B.Cols) throw new Exception("Rows or columns numbers are different. Comparison error.");
                bool flag = true;
                for (int i = 0; i < A.Rows; i++)
                {
                    for (int j = 0; j < A.Cols; j++)
                    {
                        if (A[i, j] == B[i, j]) return false;
                    }
                }
                return flag;
            }
    }

}
