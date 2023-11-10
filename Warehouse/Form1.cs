using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Microsoft.Win32;
using Resto_Frontend.Events_and_Validator.CLASS;
using Warehouse.Properties;

namespace Warehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        public static class PublicRegion
        {
            public static CultureInfo GetSystemNonUnicodeLanguage()
            {
                //HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Nls\Language
                const string subkey = @"SYSTEM\CurrentControlSet\Control\Nls\Language\";
                var regKey = Registry.LocalMachine.OpenSubKey(subkey);
                var keyValue = regKey.GetValue("Default");  // Not "(Default)"
                {
                    if (keyValue == null)
                        keyValue = regKey.GetValue(null);
                }

                var allCultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
                var currentCulture = allCultures.FirstOrDefault(item =>
                    item.LCID.ToString("X4").Contains(keyValue.ToString())); // To hex string

                return currentCulture;
            }


        }
        public Boolean isSuccessPrintZreading { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            //dito maglalagay ng input
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            string[] spellings = { "recieve", "receeve", "receive" };
            sb.AppendFormat("Which of the following spellings is {0}:", flag);
            sb.AppendLine();
            for (int ctr = 0; ctr <= spellings.GetUpperBound(0); ctr++)
            {
                sb.AppendFormat("   {0}. {1}", ctr, spellings[ctr]);
                sb.AppendLine();
            }
            sb.AppendLine();
            
            sb.Append("albertpogi");
            sb.AppendLine();
            sb.AppendLine(" " + myPrinterSetting.CenterText("*** End of Report ***",3));
            sb.AppendLine(String.Format("{0," +(10)+ "}", "------------------------"));
            sb.AppendLine(String.Format("{0," +(10)+ "}", "------------------------"));
            sb.AppendLine(String.Format("{0," +(10)+ "}", "------------------------"));
            sb.AppendLine(String.Format("{0," +(10)+ "}", "------------------------"));
            sb.AppendLine(String.Format("{0," +(10)+ "}", "------------------------"));
            sb.AppendLine(String.Format("{0," +(10)+ "}", "------------------------"));
            sb.AppendLine(String.Format("{0," +(10)+ "}", "------------------------"));
            sb.AppendLine(String.Format("{0," +(10)+ "}", "------------------------"));
            sb.AppendLine(String.Format("{0," +(10)+ "}", "------------------------"));
            
//            sb.AppendLine("GOOO FOUR FOOD CORPORATION\n"+
//"G / F Unit 6 Oxford Parksuites Masangkay St.\n"+
// "Barangay 260 Zone 24 Tondo I / II NCR,\n"+
//     "City of Manila, First District\n"+
//          "TIN 601 - 315 - 650 - 000\n"+
//                 "MIN:\n"+
//               "Serial #:\n"+
//                "Acc. #:\n"+


            //               "Z - READING\n"+
            //             "Non - Resettable" +


            //             "Dayend Report\n"+
            //    "For The Day of 2022 - 11 - 17 09:00\n"+
            //                   "2022 - 11 - 17 23:59\n"+
            //       "Running: 2022 - 11 - 22 16:19\n"+
            //"TERMINAL No.: 002\n"+
            //"----------------------------------------\n"
            //                +"------------------------\n"
            //+"Z COUNTER: 527\n"
            //       + "\n * **END OF REPORT * **"

            //);

            Console.WriteLine(sb.ToString());

            //dito magpapasa ng input
            String outs = sb.ToString();

            IntPtr pBytes;
            Int32 dwCount;

            var region = PublicRegion.GetSystemNonUnicodeLanguage();

            if (!region.ToString().Contains("CN"))
            {
                try
                {

                    byte[] converted = Encoding.GetEncoding(936).GetBytes(sb.ToString());
                    outs = (Encoding.GetEncoding("Windows-1252").GetString(converted));
                }
                catch (Exception)
                {

                    outs = sb.ToString();
                }
            }
            else
            {
                try
                {

                    byte[] converted = Encoding.GetEncoding(936).GetBytes(sb.ToString());
                    outs = (Encoding.GetEncoding(936).GetString(converted));
                }
                catch (Exception ex)
                {

                    outs = sb.ToString();
                }
            }
            // How many characters are in the string?
            // Fix from Nicholas Piasecki:
            dwCount = getlength(outs);
            //dwCount = (szString.Length + 1) * Marshal.SystemMaxDBCSCharSize;

            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(outs);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            Cut_Command();

            isSuccessPrintZreading = true;

        }

        private void SendStringToPrinter(string v)
        {
            throw new NotImplementedException();
        }

        string Cut_Command()
        {
            string GS = Convert.ToString((char)29);
            string ESC = Convert.ToString((char)27);
            string cut = string.Empty;
            cut = "/n/n " + ESC + "@";
            cut += GS + "V" + (char)1;

            return cut;
        }
        public static int getlength(string m_desc)
        {
            //tagakuha lang ng count
            
            string word = m_desc.Trim();
            int m_length = 0;
            for (int x = 0; x < word.Length; x++)
            {
                UnicodeCategory cat = char.GetUnicodeCategory(word[x]);
                if (cat == UnicodeCategory.OtherLetter)
                {
                    m_length += 2;
                }
                else
                {
                    m_length += 1;
                }
            }
            return m_length;
        }
        public static bool SendBytesToPrinter(IntPtr pBytes, Int32 dwCount)
        {
            //taga print
                Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "alrewrewrewrewrewrwrwrewrewrwerewrew";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter("CASHIER", out hPrinter, IntPtr.Zero))
            {   
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }

        private void BTNWHOLESALE_Click(object sender, EventArgs e)
        {

        }
    }
}
