using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using PdfiumViewer;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using System.Linq.Expressions;
using System.Net.Sockets;

namespace mome
{
    public partial class Form1 : Form
    {
        const int MAX_WIDTH = 170;
        const int MIN_WIDTH = 50;
        //슬라이딩 메뉴 속도
        const int SLIDING = 10;
        //최초 슬라이딩 메뉴 크기
        int slide = 170;
        public Form1()
        {
            InitializeComponent();
            Initializecb(cb1);
            Initializecb(cb2);
        }
        private void Initializecb(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.AddRange(new string[] { "ko", "en", "zh", "ja", "es" });
            cb.SelectedIndex = 0;
        }

        private void openImgToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //이미지 파일 가져오기
                pictureBox3.Image = new Bitmap(ofd.FileName);

                //이미지 텍스트 추출
                Bitmap oc = (Bitmap)pictureBox3.Image.Clone();
                string ocr = OCRprocess(oc);

                //텍스트박스 입력
                txt1.Clear();
                txt1.AppendText(ocr.Replace("\n", "\r\n") + "\r\n");

                ckhide.Checked = true;
            }
        }
        public string OCRprocess(Bitmap oc)
        {
            try
            {   //tessdata를 저장했던 경로를 지정
                //string tessdataPath = Application.StartupPath + @"\tessdata";
                //string tessdataPath = @"C:\Program Files\Tesseract-OCR\tessdata"; //환경변수코드를 입력해주기 
                // 환경 변수로 tessdata 경로 설정
                Environment.SetEnvironmentVariable("TESSDATA_PREFIX", @"C:\Program Files\Tesseract-OCR\");

                //여러 언어 인식 
                string ocrLang = "eng+jpn+chi_sim+kor";

                //Engine을 통해 OCR 실행 
                //using (var engine = new Tesseract.TesseractEngine(tessdataPath, "eng", Tesseract.EngineMode.TesseractOnly))
                using (var engine = new Tesseract.TesseractEngine(@"C:\Program Files\Tesseract-OCR\tessdata", ocrLang, Tesseract.EngineMode.Default))
                {
                    using(var page = engine.Process(oc))
                    {
                        return page.GetText();
                    }
                }
            }
            catch(Exception ex)
            {
                return "OCR Error: " + ex.Message + "\nStack Trace: " + ex.StackTrace;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void btnT_Click(object sender, EventArgs e)
        {
            TranslateService ts = new TranslateService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyAd4kYy0DoY9E2piz77LcXCXau6-TGPmjA",
                ApplicationName = ""
            });
            string originalString = txt1.Text;//txt1의 텍스트
            string lang = cb1.SelectedItem.ToString(); //번역할 언어 
            string lang2 = cb2.SelectedItem.ToString(); //번역할 언어 

            try
            {
                //번역1 요청
                TranslationsListResponse response = ts.Translations.List(originalString, lang).Execute();
                //번역1 결과
                txt2.Clear();
                txt2.Text = response.Translations[0].TranslatedText;

                //번역2 요청
                TranslationsListResponse response2 = ts.Translations.List(originalString, lang2).Execute();
                //번역2 결과
                txt3.Clear();
                txt3.Text = response2.Translations[0].TranslatedText;
            }
            catch (Exception ex)
            {
                txt2.Text = "Translator Error" + ex.Message;
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void cb2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panel1_MouseHover(object sender, EventArgs e) { }
        private void ckhide_CheckedChanged(object sender, EventArgs e)
        {
            if(ckhide.Checked) 
            {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시 
                //Image btnimg2 = Image.FromFile(@"C:\Users\KOSTA\Desktop\Project Folder\C#\img\pdf.png");
                button2.Text = "pdf";
                //Image btnimg1 = Image.FromFile(@"C:\Users\KOSTA\Desktop\Project Folder\C#\img\image.png");
                button1.Text = "img";
                ckhide.Text = ">";
            }
            else
            {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                button2.Text = "PDF";
                button2.Image = null;
                button1.Text = "Image";
                button1.Image = null;
                ckhide.Text = "<";
            }
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(ckhide.Checked)
            {
                //슬라이딩 메뉴 숨기는 동작
                slide -= SLIDING;
                if (slide <= MIN_WIDTH)
                    timer.Stop();
            }
            else
            {
                //슬라이딩 메뉴 보이는 동작 
                slide += SLIDING;
                if(slide >= MAX_WIDTH)
                    timer.Stop();
            }
            panel.Width = slide;
        }


        //pdf 파일 업로드 버튼 
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialg = new OpenFileDialog();
            openFileDialg.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if(openFileDialg.ShowDialog() == DialogResult.OK)
            {
                string pdfPath = openFileDialg.FileName;
                string ocrText = ExtractTextFromPdf(pdfPath);
                txt1.Text = ocrText;

                ckhide.Checked = true;
            }
        }

        //pdf 불러오기 
        private string ExtractTextFromPdf(string pdfPath)
        {
            try
            {
                using(var document = PdfiumViewer.PdfDocument.Load(pdfPath))
                {
                    txt1.Clear();
                    string resultText = "";
                    for (int pageIndex= 0; pageIndex < document.PageCount; pageIndex++)
                    {
                        using(var page=document.Render(pageIndex, 300,300,true))
                        {
                            using (var bitmap = new Bitmap(page))
                            {
                                string ocrText = OCRprocess(bitmap);
                                string[] lines = ocrText.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                                foreach(var line in lines)
                                {
                                    txt1.AppendText(line+Environment.NewLine);
                                }
                                resultText += ocrText + "\n";
                            }
                        }
                    }
                    return resultText;
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message + "\nStack Trace: " + ex.StackTrace;
            }
        }
    }
}
