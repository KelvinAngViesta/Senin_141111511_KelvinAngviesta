using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace ProblemVolleyBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static long Faktorial(long Fakto)
        {
            if (Fakto == 0 || Fakto == 1)
                return 1;
            long HasilFaktorial = (Fakto - 1) * Fakto;

            return HasilFaktorial;
        }
        public static BigInteger ModInverse(BigInteger a, BigInteger n)
        {
            /*Use http://stackoverflow.com/questions/7483706/c-sharp-modinverse-function */
            BigInteger i = n, v = 0, d = 1;
            while (a > 0)
            {
                BigInteger t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0)
            {
                v = (v + n) % n;
            }
            return v;
        }
    
        public static long Binomial(long n, long k)
        {
            /*Use http://stackoverflow.com/questions/12983731/algorithm-for-calculating-binomial-coefficient */
            long bufferNum = 1;
            long bufferDenom = 1;

             for (long i = n; i > Math.Abs(n - k); i--)
             {
                 bufferNum *= i;
             }

             for (long i = k; i >= 1; i--)
             {
                 bufferDenom *= i;
             }
             return Math.Abs((bufferNum /bufferDenom));
           
        }
            
            
 
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            long x = long.Parse(Txt1.Text);
            long y = long.Parse(Txt2.Text);
            long Combi = 0;
            long Nilai = 1000000000;
            if ((x >= 0 && x <= Nilai) && (y >= 0 && y <= Nilai))
            {

                if (((x == 25 && y < 24) || (y == 25 && x < 24)) || ((x >= 24 && y >= 24)))
                {
                    long sum = x + y - 1;
                    if (x > y)
                    {
                        Combi =  Binomial(sum, y);
                    }
                    else
                    {
                        Combi = Binomial(sum, x);
                    }
                }
                else
                {
                    Combi = 0;
                }
            }

            TxtHasil.Text = Combi.ToString();
        }


    }
}

