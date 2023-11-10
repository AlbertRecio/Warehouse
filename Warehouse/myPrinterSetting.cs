using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Resto_Frontend.Events_and_Validator.CLASS
{

    public class myPrinterSetting
    {
        public static bool CheckMyPrinter(string printerToCheck)
        {
            bool not_available = false;
            using (var lps = new LocalPrintServer())
            {
                try
                {
                    if (printerToCheck.Contains("\\"))
                    {
                        string _printserver = printerToCheck.Split('\\')[2];
                        string _printername = printerToCheck.Split('\\')[3];
                        PrintServer printServer = new PrintServer(@"\\" + _printserver);
                        PrintQueue printQueue = printServer.GetPrintQueue(_printername);
                        not_available = printQueue.IsNotAvailable;
                    }
                    else
                    {
                        using (var queue = lps.GetPrintQueue(printerToCheck))
                        {
                            not_available = queue.IsNotAvailable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }

            }
            return not_available;
        }

        #region GlobalVariable
        public static int PrinterWidth = 40;
        public string myProperty { get; set; }
        public Guid transID { get; set; }
        public String brokenline = String.Concat(Enumerable.Repeat('-', 40));
        public static string fontfamily = "";

        public static string PrinterName = "albert";


        #endregion
        #region pang ResiboPayment
        #region MyRegion
        public static bool isDuplicateCashier { get; set; }
        public static bool isActiveTableSlip { get; set; }

        #endregion

        #endregion
        #region PrintSales_Payment


        private int myVar;

        public int MyProperty {
            get { return myVar; }
            set { myVar = value; }
        }


        public static void CompanyLogo_Click()
        {
            Int32 pwidth = 40 / 2;
            PrintDocument document = new PrintDocument();
            PrintController printController = new StandardPrintController();
            string defaultPrinter = PrinterName;
            document.PrintController = printController;
            document.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("First custom size", pwidth, 2500);
            document.PrintPage -= printImages;
            document.PrintPage += printImages;


            document.PrinterSettings.PrinterName = defaultPrinter;
            document.Print();



        }

        private static void printImages(object sender, PrintPageEventArgs e)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="newWidth">GUSTO MONG SAGAD NA WIDTH</param>
        /// <param name="maxHeight">YUNG MAX HEIGHT NG IMAGE</param>
        /// <param name="onlyResizeIfWider">only Resize If Wider</param>
        /// <returns></returns>
        public static Image Resize(Image image, int newWidth, int maxHeight, bool onlyResizeIfWider)
        {
            if (onlyResizeIfWider && image.Width <= newWidth) newWidth = image.Width;

            var newHeight = image.Height * newWidth / image.Width;
            if (newHeight > maxHeight)
            {
                // Resize with height instead  
                newWidth = image.Width * maxHeight / image.Height;
                newHeight = maxHeight;
            }

            var res = new Bitmap(newWidth, newHeight);

            using (var graphic = Graphics.FromImage(res))
            {
                graphic.InterpolationMode = InterpolationMode.Default;
                graphic.SmoothingMode = SmoothingMode.AntiAlias;
                graphic.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                graphic.CompositingQuality = CompositingQuality.GammaCorrected;
                graphic.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return res;
        }

        public static void PrinerData(StringBuilder data, string cut)
        {
            

        }
        public String MyPropertyForm { get; set; }

        StringBuilder label;
        static int xaxis = PrinterWidth / 2;

        StringBuilder headerString, FooterString;
        bool online = false;
        public void displayDAtafromGifts(Decimal totalExcessofGC, Guid PaymentID)
        {
            
        }
  

        public void print_Document(bool PrintNow, String Msg)
        {
            // await Task.Run(() =>int
            //  {

            StringBuilder sbForExportFIle = new StringBuilder();


            int totalExcessChars = 0;


        }


        #region Format V2
        public static string CenterText(string text, int paperwidth)
        {
            StringBuilder result = new StringBuilder();
            int left = (paperwidth - text.Length) / 2;
            for (int x = 0; x < left; ++x)
            {
                result.Append(' ');
            }
            result.Append(text);
            int right = paperwidth - result.Length;
            for (int x = 0; x < right; ++x)
            {
                result.Append(' ');
            }
            return result.ToString();
        }
        #endregion

        #endregion

        #region QR CODE GEnerator
        public static String QRCodeGenerator(String refs)
        {
            string ESC = Convert.ToString((char)27);
            string GS = Convert.ToString((char)29);
            string center = ESC + "a" + (char)1; //align center
            string left = ESC + "a" + (char)0; //align left
            string bold_on = ESC + "E" + (char)1; //turn on bold mode
            string bold_off = ESC + "E" + (char)0; //turn off bold mode
            string cut = ESC + "d" + (char)1 + GS + "V" + (char)66; //add 1 extra line before partial cut
            string initp = ESC + (char)64; //initialize printer
            string buffer = ""; //store all the data that want to be printed
            string QrData = refs.ToString(); //data to be print in QR code
            Encoding m_encoding = Encoding.GetEncoding("iso-8859-1"); //set encoding for QRCode
            int store_len = (QrData).Length + 3;
            byte store_pL = (byte)(store_len % 256);
            byte store_pH = (byte)(store_len / 256);
            buffer += initp; //initialize printer
            buffer += center;
            buffer += m_encoding.GetString(new byte[] { 29, 40, 107, 4, 0, 49, 65, 50, 0 });
            buffer += m_encoding.GetString(new byte[] { 29, 40, 107, 3, 0, 49, 67, 8 });
            buffer += m_encoding.GetString(new byte[] { 29, 40, 107, 3, 0, 49, 69, 48 });
            buffer += m_encoding.GetString(new byte[] { 29, 40, 107, store_pL, store_pH, 49, 80, 48 });
            buffer += QrData;
            buffer += m_encoding.GetString(new byte[] { 29, 40, 107, 3, 0, 49, 81, 48 });

            //Cut Receipt
            buffer += initp;


            return buffer;
        }
        #endregion




        #region Printin IMage
        
        
        public class BitmapData
        {
            public BitArray Dots
            {
                get;
                set;
            }

            public int Height
            {
                get;
                set;
            }

            public int Width
            {
                get;
                set;
            }
        }
        #endregion






    }
    static class StringExtensions
    {
        public static IEnumerable<string> SplitOnLength(this string input, int length)
        {
            int index = 0;
            while (index < input.Length)
            {
                if (index + length < input.Length)
                    yield return input.Substring(index, length).Trim();
                else
                    yield return input.Substring(index).Trim();

                index += length;
            }
        }
    }
    public static class StringExtension
    {
        public static string GetLast(this string source, int tail_length)
        {
            if (tail_length >= source.Length)
                return source;
            return source.Substring(source.Length - tail_length);
        }
    }


}