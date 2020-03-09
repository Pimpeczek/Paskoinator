using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    

    public partial class PaskoinatorForm : Form
    {


        string stopka, stripName;
        List<string> pathList;
        List<ImageInfo> imageList;
        List<PictureBox> pictureBoxes, spacingPictureBoxes;
        Bitmap strip, spacingStrip;
        int height, width, heightPoint, picNum, spacingWidth, stopkaSize, widthRadio, spacingRadio;
        Color spacingColor;


        public PaskoinatorForm()
        {
            InitializeComponent();
            SetupVars();
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Program.defaultPath,
                Filter = "Formaty(*.BMP;*.JPG;*.JPEG;*.PNG;*.TIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.TIF",
                FilterIndex = 1,
                RestoreDirectory = true,
                Multiselect = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in openFileDialog1.FileNames)
                {
                    pathList.Add(s);

                }
                if (pathList.Count > 0)
                {
                    CreateOverview();
                }
                Program.defaultPath = Path.GetDirectoryName(pathList[0]);

            }
        }

        void ToggleInputs(bool enable)
        {
            CreateStripButton.Enabled = enable;
            GenerateOverview.Enabled = enable;
            ClearTheListButton.Enabled = enable;
            SpacingSetup.Enabled = enable;
            WidthSetup.Enabled = enable;
        }

        void ClearOverview()
        {
            for (int i = 0; i < pictureBoxes.Count; i++)
            {

                for (int j = 0; j < pictureBoxes[i].Controls.Count; j++)
                {
                    pictureBoxes[i].Controls[j].Dispose();
                }
                pictureBoxes[i].Dispose();
            }
            pictureBoxes.Clear();
            for (int i = 0; i < spacingPictureBoxes.Count; i++)
            {
                for (int j = 0; j < spacingPictureBoxes[i].Controls.Count; j++)
                {
                    spacingPictureBoxes[i].Controls[j].Dispose();
                }
                spacingPictureBoxes[i].Dispose();
            }
            spacingPictureBoxes.Clear();
            GC.Collect();
        }

        void CreateOverview()
        {
            ToggleInputs(pathList.Count != 0);
            SetupParameters();
            int pictureHeight = 0, overallHeight = 0;

            ClearOverview();
            Size size, spacingSize;
            spacingSize = new Size((stripOverview.Width - 20), (int)(spacingWidth * (float)(stripOverview.Width - 20) / width));
            PictureBox pB;
            Image im;
            for (int i = 0; i < pathList.Count; i++)
            {
                im = Image.FromFile(pathList[i]);
                pictureHeight = (int)(im.Height * (float)(stripOverview.Width - 20) / im.Width);

                size = new Size((stripOverview.Width - 20), pictureHeight);
                pB = new PictureBox
                {
                    Location = new Point(0, overallHeight),
                    Name = "OverviewImage",
                    Size = size,
                    Image = ResizeImage(im, size)
                };
                pB.MouseClick += new MouseEventHandler(OverviewElement_clicked);
                overallHeight += pictureHeight;
                pictureBoxes.Add(pB);

                if (i != pathList.Count - 1)
                {
                    pB = new PictureBox
                    {
                        Location = new Point(0, overallHeight),
                        Name = "OverviewImage",
                        Size = spacingSize,
                        BackColor = spacingColor
                    };
                    overallHeight += spacingSize.Height;
                    spacingPictureBoxes.Add(pB);
                }
            }

            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                stripOverview.Controls.Add(pictureBoxes[i]);
            }
            for (int i = 0; i < spacingPictureBoxes.Count; i++)
            {
                stripOverview.Controls.Add(spacingPictureBoxes[i]);
            }
            if (overallHeight == 0)
                width = 0;
            TextWidth.Text = "Szerokość: " + width;
            TextHeight.Text = "Wysokość: " + overallHeight * width / 200;
        }
        private void OverviewElement_clicked(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            string str = "";
            PictureBox pB = (PictureBox)sender;
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                if (pB == pictureBoxes[i])
                {
                    switch (me.Button)
                    {

                        case MouseButtons.Left:
                            if (ModifierKeys == Keys.Control)
                            {

                                if (pB == pictureBoxes[i])
                                    pathList.RemoveAt(i);
                                if (pathList.Count == 0)
                                {
                                    ClearTheListButton.Enabled = false;
                                    GenerateOverview.Enabled = false;
                                    CreateStripButton.Enabled = false;
                                    pathList.Clear();
                                }
                                CreateOverview();
                                break;
                            }
                            if (i != 0)
                            {
                                str = pathList[i - 1];
                                pathList[i - 1] = pathList[i];
                                pathList[i] = str;
                                CreateOverview();
                            }
                            break;

                        case MouseButtons.Right:
                            if (i != pictureBoxes.Count - 1)
                            {
                                str = pathList[i + 1];
                                pathList[i + 1] = pathList[i];
                                pathList[i] = str;
                                CreateOverview();
                            }
                            break;
                    }
                }
            }
        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            try
            {
                return new Bitmap(imgToResize, size);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(size.ToString());
                return ResizeImage(imgToResize, new Size(Math.Abs(size.Width / 2 + 1), Math.Abs(size.Height / 2 + 1)));
            }
        }

        int GetOverviewHeight()
        {
            int h = 0;
            foreach (PictureBox pB in pictureBoxes)
            {
                h += pB.Height;
            }
            return h;
        }

        private void RadioSpacingNone_CheckedChanged(object sender, EventArgs e)
        {
            spacingRadio = 0;
            SpacingHandInput.Enabled = false;
            SpacingPercentInput.Enabled = false;
            SpacingColorButton.Enabled = false;
            CreateOverview();
        }
        private void RadioSpacingPercent_CheckedChanged(object sender, EventArgs e)
        {
            spacingRadio = 1;
            SpacingHandInput.Enabled = false;
            SpacingPercentInput.Enabled = true;
            SpacingColorButton.Enabled = true;
            CreateOverview();
        }
        private void RadioSpacingUser_CheckedChanged(object sender, EventArgs e)
        {
            spacingRadio = 2;
            SpacingHandInput.Enabled = true;
            SpacingPercentInput.Enabled = false;
            SpacingColorButton.Enabled = true;
            CreateOverview();
        }
        private void SpacingColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true,
                AnyColor = false
            };
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                spacingColor = MyDialog.Color;
                SpacingColorShower.BackColor = spacingColor;
            }
            CreateOverview();

        }

        private void RadioWidthMax_CheckedChanged(object sender, EventArgs e)
        {
            widthRadio = 0;
            CreateOverview();
            WidthInput.Enabled = false;
        }
        private void RadioWidthAvg_CheckedChanged(object sender, EventArgs e)
        {
            widthRadio = 1;
            CreateOverview();
            WidthInput.Enabled = false;
        }
        private void RadioWidthMin_CheckedChanged(object sender, EventArgs e)
        {
            widthRadio = 2;
            CreateOverview();
            WidthInput.Enabled = false;
        }
        private void RadioWidthUser_CheckedChanged(object sender, EventArgs e)
        {
            widthRadio = 3;
            CreateOverview();
            WidthInput.Enabled = true;
        }

        private void CreateStripButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void ClearTheListButton_Click(object sender, EventArgs e)
        {
            ClearTheListButton.Enabled = false;
            GenerateOverview.Enabled = false;
            CreateStripButton.Enabled = false;
            pathList.Clear();
            CreateOverview();
        }

        private void GenerateOverview_Click(object sender, EventArgs e)
        {
            CreateOverview();
        }

        private void Paskoinator_Load(object sender, EventArgs e)
        {

        }

        void SetupVars()
        {
            height = 0;
            width = 0;
            heightPoint = 0;
            picNum = 1;
            spacingWidth = 0;
            pictureBoxes = new List<PictureBox>();
            spacingPictureBoxes = new List<PictureBox>();
            stopka = "Pasek wykonano za pomocą " + FindForm().Text;
            pathList = new List<string>();
            imageList = new List<ImageInfo>();
            spacingColor = new Color();
            spacingColor = Color.Black;
            SpacingColorShower.BackColor = spacingColor;
            Program.defaultPath = Directory.GetCurrentDirectory();
            Program.defSavePath = Directory.GetCurrentDirectory();
        }

        void Start()
        {
            ClearOverview();
            LoadFiles();
            SetupParameters();
            if (!IsAreaOk())
            {
                int w = (int)Math.Sqrt(40000000f / height * width);
                MessageBox.Show("Trochę za duży ten pasek. \nMuszisz zmniejszyć szerokość conajmniej do " + w + "px, żebym mógł go zapisać!", "Motyla noga!");
            }
            else
                CreateStrip();
        }

        void SetupParameters()
        {
            SetupWidth();
            StripsInBetween();
            SetupHeight();

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By powiększyć podgląd rozciągnij okno w dół.\n\nW podglądzie:\nLPM przesuwa obrazek w górę. \nPPM przesuwa obrazek w dół.\nLPM+Ctrl usuwa obrazek.\n\nReszta jest oczywista.", "Pomoc");
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            OptionsForm m = new OptionsForm();
            m.Show();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dla naszej cudownej społeczności wykonali:\n\nPimpeczek - projekt i kod \nTSR - ikona", "Credits");
        }

        void CreateStrip()
        {
            
            if (!GlueUsingGraphisc())
                return;
            AddSignature();
            SaveFile();
        }

        void ShowArgs(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine(args[i]);
        }


        void LoadFiles()
        {
            imageList.Clear();
            imageList = new List<ImageInfo>();
            for (int k = 0; k < pathList.Count; k++)
            {
                imageList.Add(new ImageInfo() { Path = pathList[k], Name = Path.GetFileName(pathList[k]), Size = Image.FromFile(pathList[k]).Size });
            }
        }

        void SetupWidth()
        {
            Image im;
            width = 0;
            switch (widthRadio)
            {
                case 0:
                    for (int k = 0; k < pathList.Count; k++)
                    {
                        im = Image.FromFile(pathList[k]);
                        if (width < im.Width)
                            width = im.Width;
                        im.Dispose();
                    }
                    break;
                case 2:
                    for (int k = 0; k < pathList.Count; k++)
                    {
                        im = Image.FromFile(pathList[k]);
                        if (width > im.Width || width == 0)
                            width = im.Width;
                        im.Dispose();
                    }
                    break;
                case 1:
                    if (pathList.Count != 0)
                    {
                        for (int k = 0; k < pathList.Count; k++)
                        {
                            im = Image.FromFile(pathList[k]);
                            width += im.Width;
                            im.Dispose();
                        }
                        width /= pathList.Count;
                    }
                    break;
                case 3:
                    width = (int)WidthInput.Value;
                    break;

            }
            if (width < 250)
                width = 250;
            stopkaSize = (int)(width * 0.032f);
            GC.Collect();
        }

        void StripsInBetween()
        {
            switch (spacingRadio)
            {
                case 1:
                    spacingWidth = (int)Math.Ceiling((float)SpacingPercentInput.Value * width * 0.01f);
                    break;
                case 2:
                    spacingWidth = (int)Math.Ceiling(SpacingHandInput.Value);
                    break;
            }

            if (spacingRadio != 0)
            {
                spacingStrip = new Bitmap(width, spacingWidth);
                Graphics g = Graphics.FromImage(spacingStrip);
                g.FillRectangle(new SolidBrush(spacingColor), (new Rectangle(0, 0, width, spacingWidth)));
                g.Dispose();
            }
        }

        void SetupHeight()
        {
            float tempH, tempW, tempIW;
            height = 0;
            for (int k = 0; k < imageList.Count; k++)
            {
                tempH = imageList[k].Size.Height;
                tempIW = imageList[k].Size.Width;
                tempW = width;
                tempH = tempH * tempW / tempIW;
                imageList[k].Resize = new Size(width, (int)tempH);
                height += imageList[k].Resize.Height;
                if (k != imageList.Count - 1)
                    height += spacingWidth;
            }
            height += stopkaSize;
        }

        bool IsAreaOk()
        {
            return true;// (height * width <= 40000000);
        }


        public bool GlueUsingGraphisc()
        {
            Image im;
            Graphics g = null;
            stripProgressBar.Maximum = imageList.Count;
            stripProgressBar.Value = 0;
            try
            {
                strip = new Bitmap(width, height);
                g = Graphics.FromImage(strip);
                g.Clear(SystemColors.AppWorkspace);
                heightPoint = 0;
                for (int i = 0; i < imageList.Count; i++)
                {
                    im = PaskoinatorForm.ResizeImage(Image.FromFile(imageList[i].Path), imageList[i].Resize);
                    g.DrawImage(im, new Point(0, heightPoint));
                    heightPoint += imageList[i].Resize.Height;
                    if (spacingWidth > 0 && i != imageList.Count - 1)
                    {
                        g.DrawImage(spacingStrip, new Point(0, heightPoint));
                        heightPoint += spacingWidth;
                    }
                    im.Dispose();
                    stripProgressBar.Value++;
                    stripProgressBar.Show();
                }
                g.FillRectangle(new SolidBrush(Color.Black), (new Rectangle(0, heightPoint, width, height - heightPoint)));
                g.Dispose();
                GC.Collect();
            }
            //catch (ArgumentException e)
            //{
             //   MessageBox.Show("Ty potworze. Doprowadziłeś biednego Paskoinatora do płaczu. Nie zasługiwał na potraktowanie go tak POTĘŻNYM paskiem. Przemyśl swoje postępowanie.", "Error kurwa, argument poza skalą!");
              //  return false;
            //}
            catch (OutOfMemoryException e)
            {
                MessageBox.Show("RAM się skończył. Użyłeś dokładnie " + Process.GetCurrentProcess().PrivateMemorySize64 + " bitów RAMu, a to całkiem sporo.\nPaskoinator nie zasługiwał na potraktowanie go tak POTĘŻNYM paskiem. Przemyśl swoje postępowanie.", "Error kurwa, RAMu nie ma!");
                if (g != null)
                    g.Dispose();
                strip.Dispose();
                GC.Collect();
                return false;
            }
            return true;
        }


        void AddSignature()
        {
            RectangleF rectf = new RectangleF(0, height - stopkaSize + 2, width, stopkaSize);
            Graphics g = Graphics.FromImage(strip);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString(stopka, new Font("Tahoma", width * 0.015f), Brushes.DarkRed, rectf);
            g.Flush();
            g.Dispose();
        }

        void SaveFile()
        {
            picNum = 1;

            FolderBrowserDialog folderDialog1 = new FolderBrowserDialog
            {
                SelectedPath = Program.defSavePath,
                Description = "Wybierz folder zapisu. \nDomyslnie jest to folder w którym znajduje się Paskoinator."
            };

            stripName = "1.png";
            while (File.Exists(Program.defSavePath + "\\pasek" + stripName))
            {
                stripName = picNum++ + ".png";
            }

            if (folderDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.defSavePath = folderDialog1.SelectedPath;
                try
                {
                    strip.Save(Program.defSavePath + "\\pasek" + stripName, System.Drawing.Imaging.ImageFormat.Png);


                    GC.Collect();
                    Process.Start("explorer.exe", "/select, " + Program.defSavePath + "\\pasek" + stripName);
                }
                catch(System.Runtime.InteropServices.ExternalException e)
                {
                    MessageBox.Show("System nie pozwala zapisać tego paska, prawdopodobnie był zbyt długi.\nZmniejsz szerokość.", "Nie wiem co sie dzieje...");
                    strip.Dispose();
                    GC.Collect();
                    return;
                }
            }
            strip.Dispose();
            CreateOverview();
        }

    }

    public class GluerClass
    {
        List<ImageInfo> imageList;
        Image  spacingStrip;
        int height, width, heightPoint, spacingWidth; 
        Color spacingColor;

        public GluerClass(  List<ImageInfo> imageList, Image spacingStrip,
                            int height, int width, int heightPoint, int spacingWidth,
                            Color spacingColor){
            this.imageList = imageList;
            //this.strip = new Bitmap(width, height);
            this.spacingStrip = spacingStrip;
            this.height = height;
            this.width = width;
            this.heightPoint = heightPoint;
            this.spacingWidth = spacingWidth;
            this.spacingColor = spacingColor;

        }

        
    }


    public class ImageInfo
    {
        public string Name
        {
            get;
            set;
        }
        public string Path
        {
            get;
            set;
        }
        public Size Size
        {
            get;
            set;
        }
        public Size Resize
        {
            get;
            set;
        }

    }
}
