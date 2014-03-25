using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Security;
using System.Security.Cryptography;
using System.Globalization;
using System.Web;
using System.Net;
using System.IO;



namespace CSharpConsoleTest
{

    class Program
    {
        class TestClass
        {
            //将字节数组转化为比特流
            public static void ConvertTo01(byte[] byteArray)
            {
                System.Collections.BitArray arr = new System.Collections.BitArray(byteArray);
                int j = 0;
                foreach (var i in arr)
                {

                    if ((bool)i == true)
                    {
                        Console.Write(1);
                        j++;
                    }

                    if ((bool)i == false)
                    {
                        Console.Write(0);
                        j++;
                    }
                    if (j % 8 == 0)
                        Console.Write(" ");
                }
            }
            //对语言进行性能测试
            public static void PerformanceTest(int count)
            {
                DateTime tr = DateTime.Now;
                double begin = tr.Millisecond;
                for (int i = 0; i <= count; i++)
                    ;
                tr = DateTime.Now;
                double end = tr.Millisecond;
                Console.Write(end - begin);
                Console.ReadKey();
            }
            //进行MD5加密
            public static byte[] MD5Encoding(string source)
            {
                MD5 cp = new MD5CryptoServiceProvider();
                byte[] sourceData = Encoding.Default.GetBytes(source);
                byte[] targetData = cp.ComputeHash(sourceData);                
                return targetData;
            }
            //抓取web页面
            public static string ClutchWebPage(string link)
            {
                string pageHtml = "";
                WebClient myWebClient = new WebClient();
                myWebClient.Credentials = CredentialCache.DefaultCredentials;
                Byte[] pageData = myWebClient.DownloadData(link);
                pageHtml = Encoding.UTF8.GetString(pageData);
                return pageHtml;
            }
            //创建文件
            public static void CreateFile(string path)
            {
                if (!File.Exists(path))
                    File.Create(path);
            }
            public static void webGrab()
            {
                //创建文件
                string path = @"c:\users\2292808069\desktop\merriam.txt";
                string link = @"http://www.merriam-webster.com/dictionary";
                string pageHtml = "";
                CreateFile(path);
                try
                {
                    pageHtml = ClutchWebPage(link);
                    File.WriteAllText(path, pageHtml);
                    //content = File.ReadAllText(path);
                    //Console.WriteLine(content);
                    //Regex[] rg = new Regex[2];                    
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }


            }
            //读取文件
            public static string readFile(string path)
            {
                string content = "";
                content = File.ReadAllText(path);
                return content;
            }

           
        }
        //委托
        delegate void PrintFunction();
        static void Main(string[] args)
        {
            //string source = "刘备ABC关羽ABc张飞Abc赵云abc诸葛亮aBC孙权abC周瑜AbC鲁肃aBc曹操许攸郭嘉需晃袁绍";
            //Regex regex = new Regex("孙权",RegexOptions.IgnoreCase);
            //string result = regex.Replace(source, "nima");
            //Console.WriteLine(result);
             
            //string link = @"http://www.merriam_webster.com/dictionary";
            
            //string path = @"c:\users\2292808069\desktop\merriam.txt";
            //string source = TestClass.readFile(path);
            //Regex regex = new Regex(@"<input");
            Console.ReadKey();
        }
        //读取网页信息
        

    }
}
