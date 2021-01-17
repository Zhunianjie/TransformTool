using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformTool
{
    public partial class Form1
    {
        private string[] P = new string[1005];
        private string[] Q = new string[1005];
        private string[] CT = new string[1005];
        private string[] PT = new string[1005];
        private string[] UA = new string[1005];
        private string[] UB = new string[1005];
        private string[] UC = new string[1005];
        private string[] IA = new string[1005];
        private string[] IB = new string[1005];
        private string[] IC = new string[1005];

        private void TransformB()
        {
            for (int piont = 2; piont <= 1000; piont++)
            {
                try
                {
                    if (!rawData[piont].Equals(null))
                    {
                        var strFormat = Convert.ToInt32(rawData[piont].Substring(0, 2), 16).ToString();
                        format[piont] = strFormat;

                        var strAddr = Convert.ToInt32(rawData[piont].Substring(2, 2), 16).ToString();
                        addr[piont] = strAddr;

                        var strP = rawData[piont].Substring(8, 4) + rawData[piont].Substring(4, 4);
                        strP = Convert.ToInt32(strP, 16).ToString();
                        P[piont] = strP;

                        var strQ = rawData[piont].Substring(16, 4) + rawData[piont].Substring(12, 4);
                        strQ = Convert.ToInt32(strQ, 16).ToString();
                        Q[piont] = strQ;

                        var strCT = Convert.ToInt32(rawData[piont].Substring(20, 4), 16).ToString();
                        CT[piont] = strCT;

                        var strPT = Convert.ToInt32(rawData[piont].Substring(24, 4), 16).ToString();
                        PT[piont] = strPT;

                        var strUA = Convert.ToInt32(rawData[piont].Substring(28, 4), 16).ToString();
                        UA[piont] = strUA;

                        var strUB = Convert.ToInt32(rawData[piont].Substring(32, 4), 16).ToString();
                        UB[piont] = strUB;

                        var strUC = Convert.ToInt32(rawData[piont].Substring(36, 4), 16).ToString();
                        UC[piont] = strUC;

                        var strIA = Convert.ToInt32(rawData[piont].Substring(40, 4), 16).ToString();
                        IA[piont] = strIA;

                        var strIB = Convert.ToInt32(rawData[piont].Substring(44, 4), 16).ToString();
                        IB[piont] = strIB;

                        var strIC = Convert.ToInt32(rawData[piont].Substring(48, 4), 16).ToString();
                        IC[piont] = strIC;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    piontCount = piont;
                    return;
                }
            }
        }
    }
}
