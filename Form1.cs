
using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.XPhoto;
using Microsoft.Extensions.Configuration;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Xml;

namespace med
{
 

    public partial class Form1 : Form
    {
        public Mat mat = new Mat();
        public Mat mat0 = new Mat();
        public Mat imageHSVDest = new Mat();
        public Mat matHSV = new Mat();
        public Mat gray = new Mat();
        public Mat matTest = new Mat(); 
        public Mat matRGB = new Mat();
        public Mat thresOut = new Mat();
        public Mat matOrig = new Mat();
        public Mat imageHSVDest2 = new Mat();
        public Mat frame_HSV = new Mat();
        public double area0All=0;
        public string filename = "";
        public Mat ImageHeight = new Mat();
        double areaAll;
        string rezult;
        List<string> fileProcRez = new List<string>() { };
        List<string> fileNameRez = new List<string>() { };
        

        //public Mat1b mask
        public Form1()
        {
            InitializeComponent();

        }

        void obrabotka()
        {
            area0All = 0;
            if (filename == "")
                return;            
            
            matOrig = new Mat(filename);
            mat = new Mat();
            matHSV = new Mat();
            gray = new Mat();
            matTest = new Mat();
            matRGB = new Mat();
            thresOut = new Mat();
            imageHSVDest2 = new Mat();
            frame_HSV = new Mat();
            ImageHeight = new Mat();

            CvInvoke.MedianBlur(mat0, matTest, 7);
            //CvInvoke.CvtColor(matTest, mat, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);            
            mat = matTest;
            CvInvoke.InRange(mat, new ScalarArray(new MCvScalar( selectSlider1.SelectedMin, selectSliderS.SelectedMin, selectSliderV.SelectedMin)),new ScalarArray(new MCvScalar(selectSlider1.SelectedMax, selectSliderS.SelectedMax, selectSliderV.SelectedMax)), imageHSVDest);
            ImageHeight = imageHSVDest;
            
            if (checkBox1.Checked)
            {
                CvInvoke.InRange(mat, new ScalarArray(new MCvScalar(selectSlider2.SelectedMin, selectSliderS.SelectedMin, selectSliderV.SelectedMin)), new ScalarArray(new MCvScalar(selectSlider2.SelectedMax, selectSliderS.SelectedMax, selectSliderV.SelectedMax)), imageHSVDest2);
                ImageHeight = imageHSVDest + imageHSVDest2;
            }
            // label1.Text = trackBar2.Value.ToString();
            //imageBox1.Image = ImageHeight;
            Mat struct_element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(2, 2), new System.Drawing.Point(-1, -1));
            CvInvoke.MorphologyEx(ImageHeight, ImageHeight, Emgu.CV.CvEnum.MorphOp.Open, struct_element, new System.Drawing.Point(-1, -1), 3, Emgu.CV.CvEnum.BorderType.Default,
                 new MCvScalar(0, 0, 0));

            if (checkBoxInv.Checked == true)
                ImageHeight = ~ImageHeight;            
            mat.CopyTo(matHSV, ImageHeight);
            matOrig.CopyTo(matRGB, ImageHeight);

            CvInvoke.CvtColor(matHSV, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(gray, thresOut, 0, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            
            VectorOfVectorOfPoint controls = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();
            // поиск контуров на картинке
            CvInvoke.FindContours(thresOut, controls, hierarchy, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            for (int i = 0; i < controls.Size; i++)
            {
                double area0 = CvInvoke.ContourArea(controls[i]);//площадь

                if (area0 > 2 && area0 < 850000000)
                {
                    area0All = area0All + area0;
                    CvInvoke.DrawContours(matOrig, controls, i, new MCvScalar(0, 0, 255), 4);
                }

            }
            areaAll = matOrig.Width * matOrig.Height;
            label1.Text = (area0All * 100 / areaAll).ToString("F2");
            label5.Text = controls.Size.ToString("F2");
            imageBox1.Image = matOrig;
            //matOrig = new Mat();

        }
        private void imageBox1_Click(object sender, EventArgs e)
        {
          //  CvInvoke.Imshow("Результат", matOrig);
        }

        private void selectionRangeSlider1_SelectionChanged(object sender, EventArgs e)
        {
            diapazonMin.Text = selectSlider1.SelectedMin.ToString();
            diapazonMax.Text = selectSlider1.SelectedMax.ToString();
        }
        private void selectionRangeSlider2_SelectionChanged(object sender, EventArgs e)
        {
            diapazonMin2.Text = selectSlider2.SelectedMin.ToString();
            diapazonMax2.Text = selectSlider2.SelectedMax.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            selectSlider2.Visible = false;
            diapazonMin2.Visible = false;
            diapazonMax2.Visible = false;

            diapazonMin.Text = selectSlider1.SelectedMin.ToString();
            diapazonMax.Text = selectSlider1.SelectedMax.ToString();
        
            diapazonMin2.Text = selectSlider2.SelectedMin.ToString();
            diapazonMax2.Text = selectSlider2.SelectedMax.ToString();

            int temp;
            using (var stream = File.Open("setting.xml", FileMode.Open))
            {
                System.IO.TextReader readFile = new StreamReader(stream);
                var another = Config.Read(readFile);

                selectSlider1.SelectedMin = another.selectSlider1Min;
                selectSlider1.SelectedMax = another.selectSlider1Max;
                selectSlider2.SelectedMin = another.selectSlider2Min;
                selectSlider2.SelectedMax = another.selectSlider2Max;

                selectSliderV.SelectedMin = another.selectSliderVMin;
                selectSliderV.SelectedMax = another.selectSliderVMax;
                selectSliderS.SelectedMin = another.selectSliderSMin;
                selectSliderS.SelectedMax = another.selectSliderSMax;
                temp = another.checkBox1Checked;
            }

            if (temp == 1)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                selectSlider2.Visible = true;
                diapazonMin2.Visible = true;
                diapazonMax2.Visible = true;
                obrabotka();
            }
            else
            {
                obrabotka();
                selectSlider2.Visible = false;
                diapazonMin2.Visible = false;
                diapazonMax2.Visible = false;
            }
        }

   

        private void selectionRangeSlider1_MouseUp(object sender, MouseEventArgs e)
        {
            obrabotka();
        }

        private void checkBoxInv_CheckedChanged(object sender, EventArgs e)
        {
            obrabotka();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void diapazonMax2_Click(object sender, EventArgs e)
        {

        }

        void goHtml()
        {

            //Write text to file
            StreamWriter streamwriter = new StreamWriter(@rezult + "index.html");
            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine("  <title>HTML-Document</title>");
            streamwriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");
            streamwriter.WriteLine("Файлы результатов сохранены в папку: " + rezult);
            for (int i = 0; i < fileNameRez.Count; i++)
            {
                streamwriter.WriteLine("<br><br>Файл: <a href=" + rezult + fileNameRez[i] + ">" + rezult + fileNameRez[i] + " </a ><br> Процентная заполняемость " + fileProcRez[i] + " %<br>");
                // System.Windows.Forms.MessageBox.Show("Файлы успешно сохранены в папку: " + fileNameRez[i], "Message");
                streamwriter.WriteLine("<a href=" + rezult + fileNameRez[i] + "><img src = " + rezult + fileNameRez[i] + " border = '0'  style = 'width: 900px; height: auto;' ></a ><br>");

            }
            streamwriter.WriteLine("Привет");
            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
            streamwriter.Close();
            //end write text
            //System.Diagnostics.Process.Start(rezult+"index.html");
            using (Process process = new())
            {
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = rezult + "index.html";
                process.Start();
            }
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images files|*.jpg;*.tif;*.png;*.bmp|All files(*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            mat0 = new Mat(filename);
            obrabotka();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!matOrig.IsEmpty)
            {
                saveFileDialog1.Filter = "images files|*.jpg";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл

                //Bitmap img = new Bitmap("filename.jpg");
                //img.Save("file.png", ImageFormat.Png); // ImageFormat.Jpeg, etc

                matOrig.ToBitmap().Save(filename, ImageFormat.Jpeg);
            }
        }

        private void пакетнаяОбработкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileNameRez.Clear();
            fileProcRez.Clear();
            string[] filesPath = { };
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                var ext = new List<string> { "jpg", "gif", "png", "tif" };// скисок расширений файлов
                filesPath = Directory
                            .EnumerateFiles(fbd.SelectedPath, "*.*", SearchOption.TopDirectoryOnly)
                            .Where(s => ext.Contains(Path.GetExtension(s).TrimStart('.').ToLowerInvariant())).ToArray(); // список файлов с полными путями
            
            string[] filesName = new string[filesPath.Length];
            int ii = 0;
            foreach (string file in filesPath)
            {
                //System.Windows.Forms.MessageBox.Show("1Files found: " + Path.GetFileName(file).ToString(), "Message");
                filesName[ii] = Path.GetFileName(file); // список только имен файлов
                ii = ii + 1;
            }

             rezult = fbd.SelectedPath + "\\result\\"; //новый путь
            if (!Directory.Exists(rezult)) Directory.CreateDirectory(rezult);// если нет папки создаем ее
            StreamWriter w = new StreamWriter(rezult + "result.txt", false);

            for (int i = 0; i < filesPath.Length; i++)
            {
                filename = filesPath[i];
                mat0 = new Mat(filename);
                obrabotka();
                matOrig.ToBitmap().Save(rezult + filesName[i], ImageFormat.Jpeg);
               // matOrig.ToBitmap().Save(filename, ImageFormat.Jpeg);
                    w.WriteLine("файл: " + filesName[i].ToString() + " " + (area0All * 100 / areaAll).ToString("F2") + " % ");
                    fileNameRez.Add(filesName[i].ToString());
                    fileProcRez.Add((area0All * 100 / areaAll).ToString("F2"));
                }
            w.Close();
                //System.Windows.Forms.MessageBox.Show("Файлы успешно сохранены в папку: " + rezult, "Message");
                goHtml();
            }
        }

        private void сохранитьНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp;
            if (checkBox1.Checked)
                temp = 1;
            else temp = 0;
            var adminConfig = new Config
            {
                selectSlider1Min = selectSlider1.SelectedMin,
                selectSlider1Max = selectSlider1.SelectedMax,
                selectSlider2Min = selectSlider2.SelectedMin,
                selectSlider2Max = selectSlider2.SelectedMax,
                selectSliderVMin = selectSliderV.SelectedMin,
                selectSliderVMax = selectSliderV.SelectedMax,
                selectSliderSMin = selectSliderS.SelectedMin,
                selectSliderSMax = selectSliderS.SelectedMax,
                checkBox1Checked = temp
            };
          //  File.Delete("setting.xml"); 
       
               // System.IO.TextWriter readFile = new StreamWriter(stream);
               // StreamWriter w = new StreamWriter("setting.xml", false);
            
            var settings = new XmlWriterSettings { Indent = true };
            var w = XmlWriter.Create("setting.xml", settings);
            adminConfig.Write(w);          
            w.Close();
        }

        private void неОбработанныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CvInvoke.Imshow("Результат", ImageHeight);
        }

        private void сохранитьToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            if (!matOrig.IsEmpty)
                toolStripStatusLabel1.Text = "Сохранить результат исследований";
            else
                toolStripStatusLabel1.Text = "Сохранять нечего";
        } 

        private void сохранитьToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void открытьToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Открыть фото для обработки";
        }
    }
}
[Serializable]
public class Config
{ 
    public int selectSlider1Min { get; set; }
    public int selectSlider1Max { get; set; }
    public int selectSlider2Min { get; set; }
    public int selectSlider2Max { get; set; }
    public int selectSliderVMin { get; set; }
    public int selectSliderVMax { get; set; }
    public int selectSliderSMin { get; set; }
    public int selectSliderSMax { get; set; }
    public int checkBox1Checked { get; set; }    

    public void Write(XmlWriter writer)
    {
        XmlSerializer x = new XmlSerializer(typeof(Config));
        x.Serialize(writer, this);
    }

    public static Config Read(TextReader reader)
    {
        XmlSerializer x = new XmlSerializer(typeof(Config));
        return (Config)x.Deserialize(reader);
    }
}