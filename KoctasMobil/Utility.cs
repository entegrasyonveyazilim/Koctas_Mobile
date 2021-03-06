using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;

namespace KoctasMobil
{
    class Utility
    {

        public static string getIadeTip(string iadeTip)
        {
            string iadeAciklama = "";
            switch (iadeTip)
            {
                case "A": iadeAciklama = "Normal İade"; break; 
                case "B": iadeAciklama = "Ayıplı İade"; break; 
                case "C": iadeAciklama = "Stok Fazlası"; break;
            }
            return iadeAciklama;
        }

        public static string getIadeTipReverse(string iadeAciklama)
        {
            string iadeTip = "";
            switch (iadeAciklama)
            {
                case "Normal İade": iadeTip = "A"; break;
                case "Ayıplı İade": iadeTip = "B"; break;
                case "Stok Fazlası": iadeTip = "C"; break;
            }
            return iadeTip;
        }

        public static void setSunucu(string sunucu)
        {
            switch (sunucu)
            {
                case "DEV Test": ProgramGlobalData.sunucuIp = "10.160.160.80:8000"; break;
                case "DEV Test - 2": ProgramGlobalData.sunucuIp = "10.160.160.95:8000"; break;
                case "QA Test": ProgramGlobalData.sunucuIp = "10.160.160.81:8000"; break;
                case "PROD": ProgramGlobalData.sunucuIp = "10.160.160.51:8000"; break;


                default: ProgramGlobalData.sunucuIp = "10.160.160.51:8000"; break;

            }
        }

        public static string getWsUrl(string servicename)
        {

            return "http://" + ProgramGlobalData.sunucuIp + "/sap/bc/srt/rfc/sap/" + servicename + "/500/service/service";
            
            /*
            if (Program.canli)
	        {
                 //return servicename.Replace("ktqa.koctas.com.tr","212.115.6.165");
                //return "http://212.115.6.165:8000/sap/bc/srt/rfc/sap/" + servicename + "/500/service/service";
                return "http://10.160.160.51:8000/sap/bc/srt/rfc/sap/" + servicename + "/500/service/service";
	        }
            else
            {
                //return servicename.Replace("ktqa.koctas.com.tr","212.115.6.172");
                return "http://10.160.160.80:8000/sap/bc/srt/rfc/sap/" + servicename + "/500/service/service";
                //return "http://10.160.160.51:8000/sap/bc/srt/rfc/sap/" + servicename + "/500/service/service";
            }*/
        }

        //public static AnimateCtl animate = new AnimateCtl();
        static string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
        private static string sAutoUpdateLink = "http://172.16.5.8/mobile/AutoUpdate.aspx";
        public static void LaunchLauncher()
        {
            string cmd, arg;
            Utility.ProcessInfo pi = new Utility.ProcessInfo();
            byte[] si = new byte[128];
            cmd = "\\Program Files\\Launcher\\Launcher.exe";
            arg = "0" + " \"" + GetCurrentApplicationVersion() + "\" \"" + sAutoUpdateLink + "\" \"\\Program Files\\KoctasMobil\\KoctasMobil.exe\"";
            Utility.CreateProcess(cmd, arg, IntPtr.Zero, IntPtr.Zero,
                0, 0, IntPtr.Zero, IntPtr.Zero, si, pi);
            if (Utility.WaitForSingleObject(pi.hProcess, 3000) == 0)
            {
            }
        }
        public static int CheckNewVersion()
        {
            HttpWebRequest req;
            string FileName = "";

            Uri u = new Uri(sAutoUpdateLink);
            req = (HttpWebRequest)HttpWebRequest.Create(u.ToString());
            req.Method = "GET";
            Cursor.Current = Cursors.WaitCursor;
            WebResponse rsp;
            try
            {
                rsp = req.GetResponse();
            }
            catch (WebException)
            {
                MessageBox.Show("Otomatik güncelleme sunucusuna bağlantı kurulamadı.", "Otomatik Güncelleme");
                
                return -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Otomatik güncelleme sunucusuna bağlantı kurulurken hata oluştu.", "Otomatik Güncelleme");
                return -1;
            }

            if (rsp.Headers["Content-disposition"] == null)
            {
                MessageBox.Show("Güncel versiyon dosyası bulunamadı.", "Otomatik Güncelleme");
                return -1;
            }

            // Extract file name from Content-Disposition header
            string hdrDisp = rsp.Headers["Content-disposition"];
            //rsp.Close();
            Match m;
            foreach (string part in hdrDisp.Split(new Char[] { ';' }))
            {
                m = Regex.Match(part, "filename=(.+)");

                if (m.Success)
                {
                    FileName = m.Groups[1].Value;
                    break;
                }
            }
            FileName = FileName.Trim();

            if (FileName.Substring(1, 7).CompareTo(GetCurrentApplicationVersion()) > 0)
            {
                return 1;
            }

            return 0;
        }
        public class ProcessInfo
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public Int32 ProcessId;
            public Int32 ThreadId;
        }
        public static string GetCurrentApplicationVersion()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        [DllImport("CoreDll.DLL", SetLastError = true)]
        public extern static
            int CreateProcess(String imageName,
            String cmdLine,
            IntPtr lpProcessAttributes,
            IntPtr lpThreadAttributes,
            Int32 boolInheritHandles,
            Int32 dwCreationFlags,
            IntPtr lpEnvironment,
            IntPtr lpszCurrentDir,
            byte[] si,
            ProcessInfo pi);

        [DllImport("CoreDll.dll")]
        public extern static
            Int32 WaitForSingleObject(IntPtr Handle,
            Int32 Wait);

        #region show/hide taskbar
        static int SWP_SHOWWINDOW = 0x40;
        static int SM_CXSCREEN = 0;
        static int SM_CYSCREEN = 1;
        static int HWND_TOPMOST = -1;
        static int SW_HIDE = 0;
        static int SW_SHOW = 5;

        [DllImport("CoreDll.dll")]
        private static extern int FindWindow(string lpClassName,
            string lpWindowName);
        [DllImport("CoreDll.dll")]
        private static extern int EnableWindow(int hwnd,
            bool bEnable);

        public static void HideTaskbar()
        {
            int hwnd, lret;
            hwnd = FindWindow("HHTaskBar", "");
            //lret = ShowWindow(hwnd, SW_HIDE);
            lret = EnableWindow(hwnd, false);

            /*IntPtr HWND2 = GetForegroundWindow();

            lret = SetWindowPos(HWND2, HWND_TOPMOST, 0, 0,
                GetSystemMetrics(SM_CXSCREEN) , GetSystemMetrics(SM_CYSCREEN),
                SWP_SHOWWINDOW);*/
        }

        public static void ShowTaskbar()
        {
            int hwnd;
            int lret;
            hwnd = FindWindow("HHTaskBar", "");
            //lret = ShowWindow(hwnd, SW_SHOW);
            lret = EnableWindow(hwnd, true);

            /*IntPtr HWND2 = GetForegroundWindow();

            lret = SetWindowPos(HWND2, HWND_TOPMOST, 0, 0,
                GetSystemMetrics(SM_CXSCREEN), GetSystemMetrics(SM_CYSCREEN)-24,
                SWP_SHOWWINDOW);*/
        }
        #endregion
    }
}
