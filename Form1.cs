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
using IronOcr;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using System.Linq.Expressions;

namespace mome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initializecb(cb1);
            Initializecb(cb2);
        }
        private void Initializecb(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("ko");
            cb.Items.Add("en");
            cb.Items.Add("zh");
            cb.Items.Add("ja");
            cb.Items.Add("es");
            cb.SelectedIndex = 0;
        }

        private void openImgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
              
            }
        }
        public string OCRprocess(Bitmap oc)
        {
            try
            {   //tessdata를 저장했던 경로를 지정
                //string tessdataPath = Application.StartupPath + @"\tessdata";
                //string tessdataPath = @"C:\Program Files\Tesseract-OCR\tessdata";
                // 환경 변수로 tessdata 경로 설정
                Environment.SetEnvironmentVariable("TESSDATA_PREFIX", @"C:\Program Files\Tesseract-OCR\");

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

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

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
