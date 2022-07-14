using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace RsrrPayroll
{
    public partial class frmCetakSlip : Form
    {
        private Thread workerThread = null;

        private void cetak()
        {
            string period = DateTime.Now.Month.ToString("d2") + DateTime.Now.Year.ToString();
            DataTable datakaryawan = db.get("SELECT * FROM vw_karyawan WHERE nik IN(SELECT nik from tbl_penggajian where periodeGaji='"+period+"')");
            DataTable gaji = db.get("select * from tbl_penggajian where periodeGaji='" + period + "'");
            DataTable dataTunjangan = db.get("select * from vw_tunjangan");
            DataTable dataPotongan = db.get("select * from tbl_potongan where periode='" + period + "'");

            foreach (DataRow karyawan in datakaryawan.Rows)
            {
                string nik = karyawan["nik"].ToString();
                int seq = Convert.ToInt32(karyawan["seq"].ToString());
                DataRow gj = gaji.Select("nik='"+ nik + "'").FirstOrDefault();
                Document document = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                PdfWriter w = PdfWriter.GetInstance(document, new FileStream("C:/Users/AchZh/Music/slip/"+nik+ period  + ".pdf", FileMode.Create));
                document.Open();
                string imageFilePath = "C:/Users/AchZh/Music/test/notit2.png";

                float width = document.PageSize.Width;
                float height = document.PageSize.Height;
                try
                {
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageFilePath);
                    image.ScaleToFit(340, 335);
                    image.SetAbsolutePosition((PageSize.A4.Height - image.ScaledHeight) / 2, (PageSize.A4.Width - 400) / 2);

                    PdfGState gStateHue = new PdfGState();
                    gStateHue.BlendMode = new PdfName("Hue");

                    PdfGState gStateScreen = new PdfGState();
                    gStateScreen.BlendMode = new PdfName("Screen");

                    PdfContentByte under = w.DirectContentUnder;
                    under.SaveState();
                    under.SetColorFill(BaseColor.WHITE);
                    under.Rectangle(document.PageSize.Left, document.PageSize.Bottom, document.PageSize.Width, document.PageSize.Height);
                    under.Fill();
                    under.AddImage(image);
                    //under.SetGState(gStateHue);
                    //under.SetColorFill(BaseColor.WHITE);
                    //under.Rectangle(document.PageSize.Left, document.PageSize.Bottom, document.PageSize.Width, document.PageSize.Height);
                    //under.Fill();
                    under.SetGState(gStateScreen);
                    under.SetColorFill(BaseColor.LIGHT_GRAY);
                    under.Rectangle(document.PageSize.Left, document.PageSize.Bottom, document.PageSize.Width, document.PageSize.Height);
                    under.Fill();
                    under.RestoreState();

                    var rect = new iTextSharp.text.Rectangle((PageSize.A4.Height - 780) / 2, 575, 810, 515);
                    rect.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    rect.BorderWidth = 1;
                    rect.BorderColor = new BaseColor(0, 0, 0);

                    iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance("C:/Users/AchZh/Music/test/LogoLn.png");

                    jpg.ScaleToFit(210, 210);
                    jpg.SetAbsolutePosition(42, 515);


                    BaseFont bfTimes = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false);
                    iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 11, iTextSharp.text.Font.NORMAL);


                    BaseFont bfTimes2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                    iTextSharp.text.Font times2 = new iTextSharp.text.Font(bfTimes2, 10, iTextSharp.text.Font.NORMAL);

                    BaseFont bfTimes3 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                    iTextSharp.text.Font times3 = new iTextSharp.text.Font(bfTimes3, 10, iTextSharp.text.Font.NORMAL);

                    BaseFont bfTimes4 = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false);
                    iTextSharp.text.Font times4 = new iTextSharp.text.Font(bfTimes4, 12, iTextSharp.text.Font.NORMAL);

                    BaseFont bfTimes5 = BaseFont.CreateFont(BaseFont.HELVETICA_OBLIQUE, BaseFont.CP1252, false);
                    iTextSharp.text.Font times5 = new iTextSharp.text.Font(bfTimes5, 10, iTextSharp.text.Font.ITALIC);

                    BaseFont bfTimes6 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                    iTextSharp.text.Font times6 = new iTextSharp.text.Font(bfTimes6, 11, iTextSharp.text.Font.NORMAL);

                    BaseFont bfTimes7 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                    iTextSharp.text.Font times7 = new iTextSharp.text.Font(bfTimes7, 11, iTextSharp.text.Font.UNDERLINE);
                    BaseFont bfTimes8 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                    iTextSharp.text.Font times8 = new iTextSharp.text.Font(bfTimes8, 12, iTextSharp.text.Font.UNDERLINE);

                    ColumnText ct = new ColumnText(w.DirectContent);
                    ct.SetSimpleColumn(653, 570, 810, 515);
                    ct.AddElement(new Paragraph("SLIP GAJI KARYAWAN", times));
                    ct.Go();

                    var line = new iTextSharp.text.Rectangle(627, 547, 797, 515);
                    line.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line.BorderWidth = 1;
                    line.BorderColor = new BaseColor(0, 0, 0);

                    ColumnText ct2 = new ColumnText(w.DirectContent);
                    ct2.SetSimpleColumn(670, 550, 790, 515);
                    ct2.AddElement(new Paragraph("NO. "+period+seq.ToString("d4"), times));
                    ct2.Go();

                    var line2 = new iTextSharp.text.Rectangle((PageSize.A4.Height - 780) / 2, 511, 810, 600);
                    line2.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line2.BorderWidth = 3;
                    line2.BorderColor = new BaseColor(0, 0, 0);

                    ColumnText ct3 = new ColumnText(w.DirectContent);
                    ct3.SetSimpleColumn((PageSize.A4.Height - 770) / 2, 100, 810, 500);
                    ct3.AddElement(new Paragraph("Nik", times2));
                    ct3.AddElement(new Paragraph("Nama Karyawan", times2));
                    ct3.AddElement(new Paragraph("Status Karyawan", times2));
                    ct3.AddElement(new Paragraph("Jabatan/Unit/Inst.", times2));
                    ct3.Go();

                    ColumnText ct4 = new ColumnText(w.DirectContent);
                    ct4.SetSimpleColumn((PageSize.A4.Height - 545) / 2, 100, 810, 500);
                    ct4.AddElement(new Paragraph(":", times2));
                    ct4.AddElement(new Paragraph(":", times2));
                    ct4.AddElement(new Paragraph(":", times2));
                    ct4.AddElement(new Paragraph(":", times2));
                    ct4.Go();

                    ColumnText ct5 = new ColumnText(w.DirectContent);
                    ct5.SetSimpleColumn((PageSize.A4.Height - 530) / 2, 100, 810, 500);
                    ct5.AddElement(new Paragraph(nik, times2));
                    ct5.AddElement(new Paragraph(karyawan["nama"].ToString(), times2));
                    ct5.AddElement(new Paragraph(karyawan["statusKaryawan"].ToString(), times2));
                    ct5.AddElement(new Paragraph(karyawan["profesi"].ToString()+"/"+ karyawan["Bagian"].ToString(), times2));

                    ct5.Go();

                    //sebelah

                    ColumnText ct6 = new ColumnText(w.DirectContent);
                    ct6.SetSimpleColumn(590, 100, 810, 500);
                    ct6.AddElement(new Paragraph("Kode Periode Gaji", times2));
                    ct6.AddElement(new Paragraph("Tgl Gaji", times2));
                    ct6.AddElement(new Paragraph("  "));
                    ct6.AddElement(new Paragraph("Penyerahan Gaji", times2));
                    ct6.Go();

                    ColumnText ct7 = new ColumnText(w.DirectContent);
                    ct7.SetSimpleColumn(700, 100, 810, 500);
                    ct7.AddElement(new Paragraph(":", times2));
                    ct7.AddElement(new Paragraph(":", times2));
                    ct7.AddElement(new Paragraph("  ", times2));
                    ct7.AddElement(new Paragraph(":", times2));
                    ct7.Go();

                    ColumnText ct8 = new ColumnText(w.DirectContent);
                    ct8.SetSimpleColumn(710, 100, 810, 500);
                    ct8.AddElement(new Paragraph(gj["periodeGaji"].ToString(), times2));
                    ct8.AddElement(new Paragraph(DateTime.Now.Day.ToString("d2") + "-" + DateTime.Now.Month.ToString("d2") + "-" + DateTime.Now.Year.ToString(), times2));
                    ct8.AddElement(new Paragraph("  ", times2));
                    ct8.AddElement(new Paragraph(gj["metode"].ToString(), times2));
                    ct8.Go();

                    var line3 = new iTextSharp.text.Rectangle((PageSize.A4.Height - 780) / 2, 431, 810, 600);
                    line3.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line3.BorderWidth = 1;
                    line3.BorderColor = new BaseColor(0, 0, 0);

                    ColumnText ct10 = new ColumnText(w.DirectContent);
                    ct10.SetSimpleColumn(150, 200, 810, 425);
                    ct10.AddElement(new Paragraph("PENERIMAAN", times3));
                    ct10.Go();

                    var line5 = new iTextSharp.text.Rectangle((PageSize.A4.Height - 730) / 2, 407, 325, 600);
                    line5.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line5.BorderWidth = 1;
                    line5.BorderColor = new BaseColor(0, 0, 0);

                    document.Add(line5);

                    ColumnText ct13 = new ColumnText(w.DirectContent);
                    ct13.SetSimpleColumn((PageSize.A4.Height - 715) / 2, 200, 310, 410);
                    ColumnText ct15 = new ColumnText(w.DirectContent);
                    ct15.SetSimpleColumn((PageSize.A4.Height - 725) / 2, 200, 310, 410);

                    ct13.AddElement(new Paragraph("Gaji Pokok", times2));
                    Paragraph p = new Paragraph(gj["gapok"].ToString().ToRupiah(), times2);
                    p.Alignment = Element.ALIGN_RIGHT;
                    Paragraph p5 = new Paragraph("   ", times2);
                    p5.Alignment = Element.ALIGN_RIGHT;
                    ct15.AddElement(p);
                    ct15.AddElement(p5);
                    ct13.AddElement(new Paragraph("Tunjangan :", times2));


                    DataRow[] tunjangan = dataTunjangan.Select("nik='"+nik+"'");

                    foreach (DataRow tgj in tunjangan)
                    {
                        ct13.AddElement(new Paragraph("- "+tgj["nama"].ToString(), times2));


                        Paragraph p3 = new Paragraph(tgj["nominal"].ToString().ToRupiah(), times2);
                        p3.Alignment = Element.ALIGN_RIGHT;

                        ct15.AddElement(p3);

                    }





                    ct13.AddElement(new Paragraph("Lembur", times2));
                    ct13.AddElement(new Paragraph("Insentif", times2));




                   
                    
                   
                   

                    Paragraph p8 = new Paragraph(gj["totalLembur"].ToString().ToRupiah(), times2);
                    p8.Alignment = Element.ALIGN_RIGHT;
                    Paragraph p9 = new Paragraph(gj["totalIntensif"].ToString().ToRupiah(), times2);
                    p9.Alignment = Element.ALIGN_RIGHT;


                    
                  
                    ct15.AddElement(p8);
                    ct15.AddElement(p9);



                    ct13.Go();

                    ct15.Go();


                    var line7 = new iTextSharp.text.Rectangle((PageSize.A4.Height - 730) / 2, 235, 325, 600);
                    line7.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line7.BorderWidth = 1;
                    line7.BorderColor = new BaseColor(0, 0, 0);

                    document.Add(line7);


                    ColumnText ct16 = new ColumnText(w.DirectContent);
                    ct16.SetSimpleColumn((PageSize.A4.Height - 715) / 2, 50, 310, 240);
                    ct16.AddElement(new Paragraph("Jumlah Penerimaan Gaji", times));
                    ct16.Go();

                    long totalPgaji = Convert.ToInt64(gj["gapok"].ToString()) + Convert.ToInt64(gj["totalTunjangan"].ToString()) + Convert.ToInt64(gj["totalIntensif"].ToString()) + Convert.ToInt64(gj["totalLembur"].ToString());

                    ColumnText ct17 = new ColumnText(w.DirectContent);
                    ct16.SetSimpleColumn((PageSize.A4.Height - 725) / 2, 50, 310, 240);
                    Paragraph p10 = new Paragraph(totalPgaji.ToString().ToRupiah(), times);
                    p10.Alignment = Element.ALIGN_RIGHT;
                    ct16.AddElement(p10);
                    ct16.Go();

                    //potongan
                    ColumnText ct12 = new ColumnText(w.DirectContent);
                    ct12.SetSimpleColumn(600, 200, 815, 425);
                    ct12.AddElement(new Paragraph("(POTONGAN)", times3));
                    ct12.Go();

                    var line6 = new iTextSharp.text.Rectangle(780, 407, 490, 600);
                    line6.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line6.BorderWidth = 1;
                    line6.BorderColor = new BaseColor(0, 0, 0);

                    document.Add(line6);



                    ColumnText ct21 = new ColumnText(w.DirectContent);
                    ct21.SetSimpleColumn(790, 200, 500, 410);
                    ColumnText ct22 = new ColumnText(w.DirectContent);
                    ct22.SetSimpleColumn(775, 200, 310, 410);


                    DataRow[] potongan = dataPotongan.Select("nik='"+nik+"'");

                    foreach(DataRow ptg in potongan)
                    {
                        ct21.AddElement(new Paragraph(ptg["nama"].ToString(), times2));

                        Paragraph p22 = new Paragraph(ptg["nominal"].ToString().ToRupiah(), times2);
                        p22.Alignment = Element.ALIGN_RIGHT;

                        ct22.AddElement(p22);
                    }
                    

                    ct21.Go();
                    ct22.Go();




                    var line10 = new iTextSharp.text.Rectangle(780, 235, 490, 600);
                    line10.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line10.BorderWidth = 1;
                    line10.BorderColor = new BaseColor(0, 0, 0);

                    document.Add(line10);


                    ColumnText ct19 = new ColumnText(w.DirectContent);
                    ct19.SetSimpleColumn(790, 50, 500, 240);
                    ct19.AddElement(new Paragraph("Jumlah Pemotongan Gaji", times));
                    ct19.Go();

                    ColumnText ct20 = new ColumnText(w.DirectContent);
                    ct20.SetSimpleColumn(775, 50, 310, 240);
                    Paragraph p20 = new Paragraph(gj["totalPotongan"].ToString().ToRupiah(), times);
                    p20.Alignment = Element.ALIGN_RIGHT;
                    ct20.AddElement(p20);
                    ct20.Go();


                    //end

                    var line30 = new iTextSharp.text.Rectangle((PageSize.A4.Height - 780) / 2, 200, 810, 700);
                    line30.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line30.BorderWidth = 1;
                    line30.BorderColor = new BaseColor(0, 0, 0);

                    document.Add(line30);

                    ColumnText ct24 = new ColumnText(w.DirectContent);
                    ct24.SetSimpleColumn(800, 50, 330, 205);
                    Paragraph p24 = new Paragraph("Total Penerimaan Gaji        "+ gj["totalGaji"].ToString().ToRupiah(), times4);
                    p24.Alignment = Element.ALIGN_RIGHT;
                    ct24.AddElement(p24);
                    ct24.Go();

                    var line32 = new iTextSharp.text.Rectangle((PageSize.A4.Height - 780) / 2, 182, 810, 710);
                    line32.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line32.BorderWidth = 1;
                    line32.BorderColor = new BaseColor(0, 0, 0);

                    document.Add(line32);

                    var line33 = new iTextSharp.text.Rectangle((PageSize.A4.Height - 780) / 2, 179, 810, 710);
                    line33.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line33.BorderWidth = 3;
                    line33.BorderColor = new BaseColor(0, 0, 0);

                    document.Add(line33);


                    //Tanda Tangan
                    ColumnText ct25 = new ColumnText(w.DirectContent);
                    ct25.SetSimpleColumn(800, 50, 600, 165);
                    Paragraph p25 = new Paragraph("Sidoarjo," + DateTime.Now.Day.ToString("d2") + "-" + DateTime.Now.Month.ToString("d2") + "-" + DateTime.Now.Year.ToString(), times6);
                    p25.Alignment = Element.ALIGN_CENTER;
                    ct25.AddElement(p25);
                    Paragraph p26 = new Paragraph("Penerima", times6);
                    p26.Alignment = Element.ALIGN_CENTER;
                    ct25.AddElement(p26);
                    ct25.AddElement(new Paragraph("     "));
                    ct25.AddElement(new Paragraph("     "));

                    Paragraph p27 = new Paragraph(karyawan["nama"].ToString(), times6);
                    p27.Alignment = Element.ALIGN_CENTER;
                    ct25.AddElement(p27);

                    ct25.Go();


                    ColumnText ct26 = new ColumnText(w.DirectContent);
                    ct26.SetSimpleColumn(800, 50, 250, 174);

                    Paragraph p28 = new Paragraph("     ", times6);
                    p28.Alignment = Element.ALIGN_CENTER;
                    ct25.AddElement(p28);
                    ct26.AddElement(new Paragraph(" "));
                    Paragraph p29 = new Paragraph("Disetujui Oleh", times6);
                    p29.Alignment = Element.ALIGN_CENTER;
                    ct26.AddElement(p29);
                    ct26.AddElement(new Paragraph("     "));
                    ct26.AddElement(new Paragraph("     "));
                    Paragraph p30 = new Paragraph("Kepala Bagian SDM", times7);
                    p30.Alignment = Element.ALIGN_CENTER;
                    ct26.AddElement(p30);

                    //Chunk chk = new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1.0F, 25.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_CENTER, 15));
                    //ct26.AddElement(chk);

                    Paragraph p31 = new Paragraph("dr. Ayu Rachmasari", times6);
                    p31.Alignment = Element.ALIGN_CENTER;
                    ct26.AddElement(p31);

                    ct26.Go();


                    var line4 = new iTextSharp.text.Rectangle((PageSize.A4.Height - 780) / 2, 40, 810, 700);
                    line4.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    line4.BorderWidth = 1;
                    line4.BorderColor = new BaseColor(0, 0, 0);

                    ColumnText ct11 = new ColumnText(w.DirectContent);
                    ct11.SetSimpleColumn(39, 20, 200, 40);
                    ct11.AddElement(new Paragraph("Tanggal Cetak Slip : " + DateTime.Now.Day.ToString("d2") + "-" + DateTime.Now.Month.ToString("d2") + "-" + DateTime.Now.Year.ToString(), times5));
                    ct11.Go();

                    document.Add(line);
                    document.Add(line2);
                    document.Add(line3);
                    document.Add(line4);
                    document.Add(rect);
                    document.Add(jpg);
                    document.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        public frmCetakSlip()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(workerThread == null)
            {
                timer1.Stop();
                return;
            }

            // still works: exiting
            if (workerThread.IsAlive)
                return;

            // finished
            button1.Enabled = true;
            timer1.Stop();
            progressBar1.Visible = false;
            workerThread = null;
            app.info("Cetak Slip Selesai");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;

            // start the job and the timer, which polls the thread
            button1.Enabled = false;
            workerThread = new Thread(cetak);
            workerThread.Start();
            timer1.Interval = 100;
            timer1.Start();
            
        }
    }
}
