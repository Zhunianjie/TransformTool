using OfficeOpenXml;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace TransformTool
{
    public partial class Form1 : Form
    {
        private string[] rawData = new string[1005];    //原始数据
        private string[] format = new string[1005];     //数据格式
        private string[] addr = new string[1005];       //地址码


        private string[] flowrate = new string[1005];   //瞬时流量
        private string[] heat = new string[1005];       //累计热量
        private string[] temp1 = new string[1005];      //温度1
        private string[] temp2 = new string[1005];      //温度2



        private int piontCount = 0 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGet(ExcelPackage package)
        {
            
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            var rowCount = worksheet.Dimension.Rows;    //行
            var ColCount = worksheet.Dimension.Columns; //列

            for (int row = 2; row <= rowCount+1; row++)
            {
                rawData[row] = worksheet.Cells[row-1, 1].Value.ToString().Trim(); //读取第一列所有的原始数据
            }

        }

        private void TransformA()
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

                        var strFlowrate = rawData[piont].Substring(8, 4) + rawData[piont].Substring(4, 4);    //转置
                        var int32 = Convert.ToUInt32(strFlowrate,16);
                        strFlowrate = BitConverter.ToSingle(BitConverter.GetBytes(int32), 0).ToString(CultureInfo.CurrentCulture);
                        flowrate[piont] = strFlowrate;

                        var strHeat = rawData[piont].Substring(16, 4) + rawData[piont].Substring(12, 4);
                        strHeat = Convert.ToInt64(strHeat, 16).ToString();
                        heat[piont] = strHeat;

                        var strTemp1 = rawData[piont].Substring(24, 4) + rawData[piont].Substring(20, 4);
                        int32 = Convert.ToUInt32(strTemp1, 16);
                        strTemp1 = BitConverter.ToSingle(BitConverter.GetBytes(int32), 0).ToString(CultureInfo.CurrentCulture);
                        temp1[piont] = strTemp1;

                        var strTemp2 = rawData[piont].Substring(32, 4) + rawData[piont].Substring(28, 4);
                        int32 = Convert.ToUInt32(strTemp2, 16);
                        strTemp2 = BitConverter.ToSingle(BitConverter.GetBytes(int32), 0).ToString(CultureInfo.CurrentCulture);
                        temp2[piont] = strTemp2;
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

        private void DataOut(ExcelPackage package)
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Output");

            //表头
            if (checkBox1.Checked)
            {
                worksheet.Cells[1, 1].Value = "原始数据";
                worksheet.Cells[1, 2].Value = "数据格式";
                worksheet.Cells[1, 3].Value = "地址码";
                worksheet.Cells[1, 4].Value = "P";
                worksheet.Cells[1, 5].Value = "Q";
                worksheet.Cells[1, 6].Value = "CT";
                worksheet.Cells[1, 7].Value = "PT";
                worksheet.Cells[1, 8].Value = "UA";
                worksheet.Cells[1, 9].Value = "UB";
                worksheet.Cells[1, 10].Value = "UC";
                worksheet.Cells[1, 11].Value = "IA";
                worksheet.Cells[1, 12].Value = "IB";
                worksheet.Cells[1, 13].Value = "IC";

                for (int piont = 2; piont <= piontCount; piont++)
                {
                    worksheet.Cells[piont, 1].Value = rawData[piont];
                    worksheet.Cells[piont, 2].Value = format[piont];
                    worksheet.Cells[piont, 3].Value = addr[piont];
                    worksheet.Cells[piont, 4].Value = P[piont];
                    worksheet.Cells[piont, 5].Value = Q[piont];
                    worksheet.Cells[piont, 6].Value = CT[piont];
                    worksheet.Cells[piont, 7].Value = PT[piont];
                    worksheet.Cells[piont, 8].Value = UA[piont];
                    worksheet.Cells[piont, 9].Value = UB[piont];
                    worksheet.Cells[piont, 10].Value = UC[piont];
                    worksheet.Cells[piont, 11].Value = IA[piont];
                    worksheet.Cells[piont, 12].Value = IB[piont];
                    worksheet.Cells[piont, 13].Value = IC[piont];
                }
            }
            else
            {
                worksheet.Cells[1, 1].Value = "原始数据";
                worksheet.Cells[1, 2].Value = "数据格式";
                worksheet.Cells[1, 3].Value = "地址码";
                worksheet.Cells[1, 4].Value = "瞬时流量";
                worksheet.Cells[1, 5].Value = "正累计热量";
                worksheet.Cells[1, 6].Value = "温度1";
                worksheet.Cells[1, 7].Value = "温度2";

                for (int piont = 2; piont <= piontCount; piont++)
                {
                    worksheet.Cells[piont, 1].Value = rawData[piont];
                    worksheet.Cells[piont, 2].Value = format[piont];
                    worksheet.Cells[piont, 3].Value = addr[piont];
                    worksheet.Cells[piont, 4].Value = flowrate[piont];
                    worksheet.Cells[piont, 5].Value = heat[piont];
                    worksheet.Cells[piont, 6].Value = temp1[piont];
                    worksheet.Cells[piont, 7].Value = temp2[piont];
                }
            }
           

            package.Save();


        }



        private void btn_input_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Filter = @"Excel2007(*.xlsx) | *.xlsx";//设置文件类型

            openFileDialog1.AddExtension = true; //自动添加后缀
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbx_inputpath.Text = openFileDialog1.FileName;
            }

        }

        private void btn_transform_Click(object sender, EventArgs e)
        {
            var path = tbx_inputpath.Text;
            FileInfo fileinfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; //开源软件签名
            ExcelPackage package = new ExcelPackage(fileinfo);
            label1.Text = @"转换中。。。";
            DataGet(package);
            if (checkBox1.Checked)
            {
                TransformB();
            }
            else
            {
                TransformA();
            }

            DataOut(package);
            
            label1.Text = @"转换完成";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
