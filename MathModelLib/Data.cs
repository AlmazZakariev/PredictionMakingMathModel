using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MathModelLib
{
    public class Data
    {
        private readonly string Path;
        public int[,] MyData { get; }
        public readonly int Count;
        //малый коэффициент A1
        public readonly double A1;
        //малый коэффициент A0
        public readonly double A0;
        public readonly double PirsonKoef;
        public Data(string path)
        {
            Path = path;
            using (StreamReader sr = new StreamReader(Path))
            {
                Count = Convert.ToInt32(sr.ReadLine());
                MyData = new int[Count, 2];
                for (int i = 0; i < Count; i++)
                {
                    MyData[i, 0] = i + 1;
                    MyData[i, 1] = Convert.ToInt32(sr.ReadLine());
                }
            }
            double[] Xi = new double[Count];
            double[] lnYi = new double[Count];
            double[] Yi = new double[Count];
            double[] XiMultilnUi = new double[Count];
            double[] XSqr = new double[Count];
            double[] YSqr = new double[Count];
            double[] XYi = new double[Count];
            for (int i = 0; i < Count; i++)
            {
                Xi[i] = MyData[i, 0];
                lnYi[i] = Math.Log(MyData[i, 1]);
                XiMultilnUi[i] = Xi[i] * lnYi[i];
                XSqr[i] = Xi[i] * Xi[i];
                Yi[i] = MyData[i, 1];
                YSqr[i] = Yi[i] * Yi[i];
                XYi[i] = Yi[i] * Xi[i];

            }           
            A1 = FindA1(Xi, lnYi, XiMultilnUi, XSqr);
            A0 = FindA0(Xi, lnYi);
            PirsonKoef = PirsK(Xi, Yi, XYi, XSqr, YSqr);
        }
        private double Sum(IEnumerable<double> nums)
        {
            double summ = default;
            foreach (var n in nums)
            {
                summ += n;
            }
            return summ;
        }
        private double FindA1(double[] Xi, double[] lnYi, double[] XiMultilnYi, double[] XSqr)
        {
            
            var a = (Count * Sum(XiMultilnYi) - Sum(Xi) * Sum(lnYi))/(Count*Sum(XSqr)-Math.Pow(Sum(Xi),2));
            return Math.Exp(a);
        }
        private double FindA0(double[] Xi, double[] lnYi)
        {
            var a1 = 1 / (double)Count;
            var a2 = Sum(lnYi);
            var a3 = Math.Log(Math.Abs(A1));
            var a4 = Sum(Xi);

            var a= 1 / (double)Count * Sum(lnYi) - 1 / (double)Count * Math.Log(Math.Abs(A1)) * Sum(Xi);
            return  Math.Exp(a);
            //return Math.Log(a);
            //return a;
        }
        public double Function(double x)
        {
            return A0 * Math.Pow(A1, x);
        }
        private double PirsK(double[] Xi, double[] Yi, double[] XiMultilnYi, double[] XSqr, double[] YSqr)
        {
            var res = (XiMultilnYi.Average() - Xi.Average() * Yi.Average()) / (Math.Sqrt(XSqr.Average() - Math.Pow(Xi.Average(), 2)) * Math.Sqrt(YSqr.Average()-Math.Pow(Yi.Average(),2)));
            return res;
        }
        public string RegressionEq()
        {
            return Convert.ToString(A0) + " * " + Convert.ToString(A1) + "^x";
        }
    }
}
