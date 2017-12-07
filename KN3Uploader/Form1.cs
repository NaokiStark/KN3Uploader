using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Media;
using KN3Uploader.Properties;
using System.Net;
using System.Threading;

namespace KN3Uploader
{
    public partial class Form1 : Form
    {
        Uploader uploader = new Uploader();
        bool Uploading;

        Icon UpIco;
        Icon NormalState;

        int uploadIndex = 0;

        int selectedIndex = 0;

        List<string> files = new List<string>();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            notifyIcon1.Visible = true;
            sonidoToolStripMenuItem.Checked = Settings.Default.Sound;
            iniciarMinimizadoToolStripMenuItem.Checked = Settings.Default.MinimizedStartUp;
            UpIco = Resource1.Uploading;
            NormalState = Resource1.MainIcon;

            notifyIcon1.BalloonTipClicked += NotifyIcon1_BalloonTipClicked;
            
        }

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if(notifyIcon1.BalloonTipIcon == ToolTipIcon.Info)
            {
                Process.Start(notifyIcon1.BalloonTipText);
                Clipboard.SetText(notifyIcon1.BalloonTipText);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = true;
            opf.ShowDialog();

            if (opf.FileNames.Length < 1)
                return;

            foreach(string filenames in opf.FileNames)
            {

                FileInfo fi = new FileInfo(filenames);
                if(fi.Length > 1024 * 4 * 1000) //4mb
                {
                    MessageBox.Show("kn3.net no va a subir esta imagen, lo siento :c", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    files.Add(filenames);
                    listView1.Items.Add(new ListViewItem(new string[] { fi.Name, "Esperando" }));
                }

               
            }
            
        }

        private async Task Upload() {

            Uploading = true;
            
            string file = "";


            file = files.First();

            listView1.Items[uploadIndex].SubItems[1].Text = "Subiendo"; 

            string result = await uploader.Upload("https://www.kn3.net/upload.php", file, new FileStream(file, FileMode.Open));

            if (result != "") {
                Uploading = false;
            }
            else
            {
                Uploading = false;
            }

            files.RemoveAt(0);

            //MessageBox.Show(result.Result);

            if(result != "")
            {
                try
                {
                    JObject jo = JObject.Parse(result);
                    listView1.Items[uploadIndex].SubItems[1].Text = (string)jo["direct"];
                    RunAsSTAThread(() =>
                    {
                        Clipboard.SetText((string)jo["direct"]);
                    });
                    

                    if (Settings.Default.Sound)
                    {
                        int NewVolume = ((ushort.MaxValue / 10) * 1);

                        uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));

                        waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);

                        SoundPlayer simpleSound = new SoundPlayer(Path.Combine(Application.StartupPath, "uploaded.wav"));

                        simpleSound.Play();
                    }
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = listView1.Items[uploadIndex].SubItems[1].Text;
                    notifyIcon1.ShowBalloonTip(5, "Subida exitosa", listView1.Items[uploadIndex].SubItems[1].Text, ToolTipIcon.Info);
                    

                }
                catch
                {
                    listView1.Items[uploadIndex].SubItems[1].Text = "Respuesta desconocida";

                    if (Settings.Default.Sound)
                    {
                        int NewVolume = ((ushort.MaxValue / 10) * 1);

                        uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));

                        waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);

                        SoundPlayer simpleSound = new SoundPlayer(@"fail.wav");

                        simpleSound.Play();
                    }
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.ShowBalloonTip(5, "Fallo la subida", listView1.Items[uploadIndex].SubItems[0].Text, ToolTipIcon.Error);

                }

            }
            else
            {
                listView1.Items[uploadIndex].SubItems[1].Text = "Falló";

                if (Settings.Default.Sound)
                {
                    int NewVolume = ((ushort.MaxValue / 10) * 1);
                    
                    uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
                    
                    waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);

                    SoundPlayer simpleSound = new SoundPlayer(@"fail.wav");

                    simpleSound.Play();
                }
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.ShowBalloonTip(5, "Fallo la subida", listView1.Items[uploadIndex].SubItems[0].Text, ToolTipIcon.Error);
            }

            if(file.StartsWith("clipboard_"))
                File.Delete(file);

            //files.Remove(files.First());           

            uploadIndex++;
        }

        private void checkIcon()
        {
            if (Uploading)
            {
                if(Icon != UpIco)
                {
                    Icon = UpIco;
                }

                if(notifyIcon1.Icon != UpIco)
                {
                    notifyIcon1.Icon = UpIco;
                }
            }
            else
            {
                if (Icon != NormalState)
                {
                    Icon = NormalState;
                }
                if (notifyIcon1.Icon != NormalState)
                {
                    notifyIcon1.Icon = NormalState;
                }
            }
        }

        private async void timer1_Tick()
        {
            timer12.SynchronizingObject = null;
            checkIcon();

            if (!Uploading)
            {
                Text = "kn3 Uploader";
                notifyIcon1.Text = Text;
            }
            else
            {
                Text = "Subiendo: " + listView1.Items[uploadIndex].SubItems[0].Text;
                notifyIcon1.Text = Text;
            }

            if (files.Count < 1)
                return;

            if (!Uploading)
            {
                try
                {
                    await Upload();
                }
                catch
                {
                    //??
                }
            }
                
        }

        static void RunAsSTAThread(Action goForIt)
        {
            AutoResetEvent @event = new AutoResetEvent(false);
            Thread thread = new Thread(
                () =>
                {
                    goForIt();
                    @event.Set();
                });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            @event.WaitOne();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                selectedIndex = listView1.SelectedIndices[0];
                string x = listView1.Items[selectedIndex].SubItems[1].Text;

                if(x != "Respuesta desconocida" && x != "Falló" && x != "Subiendo" && x != "Esperando")
                    contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void copiarEnlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listView1.Items[selectedIndex].SubItems[1].Text);
        }

        private void limpiarColaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Uploading) {
                MessageBox.Show("Debe esperar a que terminen las descargas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult dlg = MessageBox.Show("¿Seguro que deseas limpiar la cola de descargas?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(dlg == DialogResult.Yes)
            {
                files.Clear();
                listView1.Items.Clear();
            }            
        }

        private void timer12_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer1_Tick();
        }

        private void textoPlanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextShow txs = new TextShow();
            
            txs.Show();

            foreach(ListViewItem lvi in listView1.Items)
            {
                if (lvi.SubItems[1].Text.StartsWith("http"))
                {
                    txs.textBox1.Text += "\n" + lvi.SubItems[1].Text;
                }                
            }            
        }

        private void bBCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextShow txs = new TextShow();

            txs.Show();

            foreach (ListViewItem lvi in listView1.Items)
            {
                if (lvi.SubItems[1].Text.StartsWith("http"))
                {
                    txs.textBox1.Text += "\n[img=" + lvi.SubItems[1].Text+"]";
                }
            }
        }

        private void desdePortapapelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Clipboard.GetImage();

            bool fromurl = false;
            string imageurl = "";
            if (img == null)
            {                
                imageurl = Clipboard.GetText();
                if (imageurl == "")
                {
                    MessageBox.Show("No hay ninguna imagen en el portapapeles.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    if(!imageurl.StartsWith("http://") && !imageurl.StartsWith("https://"))
                    {
                        MessageBox.Show("Url con formato incorrecto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    fromurl = !fromurl;
                }

            }

            string pathTemp = Path.GetTempPath() + "Clipboard_" + RandomString(4);

            if (fromurl)
            {
                try
                {
                    var u = new Uri(imageurl);
                    var fi = new FileInfo(u.AbsolutePath);
                    var ext = fi.Extension;

                    if (string.IsNullOrWhiteSpace(ext))
                        ext = "";

                    pathTemp += ext;
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(imageurl, pathTemp);

                    files.Add(pathTemp);

                    listView1.Items.Add(new ListViewItem(new string[] { new FileInfo(pathTemp).Name, "Esperando" }));
                }
                catch
                {
                    MessageBox.Show("No hay ninguna imagen en el portapapeles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            else
            {
                pathTemp += ".png";
                img.Save(pathTemp, ImageFormat.Png);

                files.Add(pathTemp);

                listView1.Items.Add(new ListViewItem(new string[] { new FileInfo(pathTemp).Name, "Esperando" }));
            }
           

        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void abrirEnlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(listView1.Items[selectedIndex].SubItems[1].Text);
        }

        private void capturarPantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            IntPtr handle = User32.GetDesktopWindow();
            // get te hDC of the target window
            IntPtr hdcSrc = User32.GetWindowDC(handle);
            // get the size
            User32.RECT windowRect = new User32.RECT();
            User32.GetWindowRect(handle, ref windowRect);
            int width = windowRect.right - windowRect.left;
            int height = windowRect.bottom - windowRect.top;
            // create a device context we can copy to
            IntPtr hdcDest = GDI32.CreateCompatibleDC(hdcSrc);
            // create a bitmap we can copy it to,
            // using GetDeviceCaps to get the width/height
            IntPtr hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, width, height);
            // select the bitmap object
            IntPtr hOld = GDI32.SelectObject(hdcDest, hBitmap);
            // bitblt over
            GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY);
            // restore selection
            GDI32.SelectObject(hdcDest, hOld);
            // clean up 
            GDI32.DeleteDC(hdcDest);
            User32.ReleaseDC(handle, hdcSrc);

            // get a .NET image object for it
            Image img = Image.FromHbitmap(hBitmap);
            // free up the Bitmap object
            GDI32.DeleteObject(hBitmap);

            /*

            CURSORINFO pci;
            pci.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(CURSORINFO));
            using (Graphics g = Graphics.FromImage(img))
            {
                if (GetCursorInfo(out pci))
                {
                    if (pci.flags == CURSOR_SHOWING)
                    {
                        DrawIcon(g.GetHdc(), pci.ptScreenPos.x, pci.ptScreenPos.y, pci.hCursor);
                        g.ReleaseHdc();
                    }
                }
            }*/

            string pathTemp = Path.GetTempPath() + "Desktop_" + RandomString(4) + ".png";

            
            img.Save(pathTemp, ImageFormat.Png);

            files.Add(pathTemp);

            listView1.Items.Add(new ListViewItem(new string[] { new FileInfo(pathTemp).Name, "Esperando" }));
            this.Opacity = 1;
            this.ShowInTaskbar = true;
        }

        private class GDI32
        {

            public const int SRCCOPY = 0x00CC0020; // BitBlt dwRop parameter

            [DllImport("gdi32.dll")]
            public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
                int nWidth, int nHeight, IntPtr hObjectSource,
                int nXSrc, int nYSrc, int dwRop);
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth,
                int nHeight);
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
            [DllImport("gdi32.dll")]
            public static extern bool DeleteDC(IntPtr hDC);
            [DllImport("gdi32.dll")]
            public static extern bool DeleteObject(IntPtr hObject);
            [DllImport("gdi32.dll")]
            public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
        }

        /// <summary>
        /// Helper class containing User32 API functions
        /// </summary>
        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetDesktopWindow();
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowDC(IntPtr hWnd);
            [DllImport("user32.dll")]
            public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);
                        
        }

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        [StructLayout(LayoutKind.Sequential)]
        struct CURSORINFO
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public POINTAPI ptScreenPos;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct POINTAPI
        {
            public int x;
            public int y;
        }

        const Int32 CURSOR_SHOWING = 0x00000001;

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(out CURSORINFO pci);

        [DllImport("user32.dll")]
        static extern bool DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);

        private void sonidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sonidoToolStripMenuItem.Checked = !sonidoToolStripMenuItem.Checked;

            Settings.Default.Sound = sonidoToolStripMenuItem.Checked;
            Settings.Default.Save();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void desdeArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void desdePortapapelesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            desdePortapapelesToolStripMenuItem_Click(sender, e);
        }

        private void capturarPantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capturarPantallaCompletaToolStripMenuItem_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = false;
            }
        }

        private void abrirVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Show();
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void iniciarMinimizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciarMinimizadoToolStripMenuItem.Checked = !iniciarMinimizadoToolStripMenuItem.Checked;

            Settings.Default.MinimizedStartUp = iniciarMinimizadoToolStripMenuItem.Checked;
            Settings.Default.Save();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.MinimizedStartUp)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            abrirVentanaToolStripMenuItem_Click(sender, e);
        }
    }
}
