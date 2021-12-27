using System;
using System.Collections.Generic;
using System.Text;

namespace CGLab69.helpers
{
    class MatrixHelpers
    {
        static public double[,] multiply(double[,] x, double[,] y)
        {
            int rowsX = x.GetLength(0);
            int rowsY = y.GetLength(0);

            int colsX = x.GetLength(1);
            int colsY = y.GetLength(1);
            
            if (colsX != rowsY)
            {
                throw new ArgumentException();
            }
            
            double t;
            double[,] res = new double[rowsX, colsY];

            for (int i = 0; i < rowsX; i++)
            {
                for (int j = 0; j < colsY; j++)
                {
                    t = 0;
                    for (int k = 0; k < colsX; k++)
                    {
                        t += x[i, k] * y[k, j];
                    }
                    res[i, j] = t;
                }
            }
            return res;
            
        }

        static public double[,] Offset(double tx, double ty, double tz)
        {
            double[,] res = new double[4, 4];
            res[3, 0] = tx;
            res[3, 1] = ty;
            res[3, 2] = tz;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == i)
                    {
                        res[i, j] = 1;
                    }
                    else
                    {
                        res[i, j] = 0;
                    }
                }
            }
            return res;
        }
        static public double[,] RotationX(double tx)
        {
            double[,] res = new double[4, 4];
            var radX = tx * Math.PI / 180;
           
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == i)
                    {
                        res[i, j] = 1;
                    }
                    else
                    {
                        res[i, j] = 0;
                    }
                }
            }
            res[1, 1] = Math.Cos(radX);
            res[1, 2] = Math.Sin(radX);
            res[2, 1] = -1*Math.Sin(radX);
            res[2, 2] = Math.Cos(radX);
            return res;
        }
        static public double[,] RotationY(double ty)
        {
            double[,] res = new double[4, 4];
            var radY = ty * Math.PI / 180;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == i)
                    {
                        res[i, j] = 1;
                    }
                    else
                    {
                        res[i, j] = 0;
                    }
                }
            }
            res[0, 0] = Math.Cos(radY);
            res[0, 2] = Math.Sin(radY);
            res[2, 0] = -1 * Math.Sin(radY);
            res[2, 2] = Math.Cos(radY);
            return res;
        }

        static public double[,] RotationZ(double tz)
        {
            double[,] res = new double[4, 4];
            var radZ = tz * Math.PI / 180;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == i)
                    {
                        res[i, j] = 1;
                    }
                    else
                    {
                        res[i, j] = 0;
                    }
                }
            }
            res[0, 0] = Math.Cos(radZ);
            res[1, 0] = Math.Sin(radZ);
            res[0, 1] = -1 * Math.Sin(radZ);
            res[1, 1] = Math.Cos(radZ);
            return res;
        }
        static public double[,] Scale(double mx, double my, double mz)
        {
            double[,] res = new double[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == i)
                    {
                        res[i, j] = 1;
                    }
                    else
                    {
                        res[i, j] = 0;
                    }
                }
            }
            res[0, 0] = mx;
            res[1, 1] = my;
            res[2, 2] = mz;
           
            return res;
        }
    }
}
