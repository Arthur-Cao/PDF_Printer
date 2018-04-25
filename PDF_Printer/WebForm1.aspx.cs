using EO.Pdf;
using EO.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;




namespace PDF_Printer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ASPXToPDF pdf = new ASPXToPDF();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            HtmlGenericControl div = new HtmlGenericControl("div");
            HtmlTable tb = new HtmlTable();
            tb.ID = "text";         
            for (int i = 0; i <4; i++)
            {
                HtmlTableRow tr = new HtmlTableRow();
                for (int ii = 0; ii < 3; ii++)
                {
                    HtmlTableCell td = new HtmlTableCell();
                    td.InnerText = (i + ii).ToString();
                    tr.Controls.Add(td);
                }
                tb.Controls.Add(tr);
            }

            Button bn = new Button();
            bn.Click +=new EventHandler(this.Bn_Onclick);
            bn.ID = "MyButton";
            bn.Text = "DownLoad";
            div.Controls.Add(tb);
            div.Controls.Add(bn);
            this.Page.FindControl("form1").Controls.Add(div);
            }
            else
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                HtmlTable tb = new HtmlTable();
                tb.ID = "text";
                for (int i = 0; i < 4; i++)
                {
                    HtmlTableRow tr = new HtmlTableRow();
                    for (int ii = 0; ii < 3; ii++)
                    {
                        HtmlTableCell td = new HtmlTableCell();
                        td.InnerText = (i + ii).ToString();
                        tr.Controls.Add(td);
                    }
                    tb.Controls.Add(tr);
                }

                Button bn = new Button();
                bn.Click += new EventHandler(this.Bn_Onclick);
                bn.ID = "MyButton";
                bn.Text = "DownLoad";
                div.Controls.Add(tb);
                div.Controls.Add(bn);

                this.Page.FindControl("form1").Controls.Add(div);
                //this.Page.FindControl("form1").Controls.Add(pdf);
            }
        }

        public void Bn_Onclick(Object sender, EventArgs e)
        {
            down_Load();

        }

        public void down_Load() {

            //pdf.RenderAsPDF("report.pdf");
            //pdf.AfterRender += Pdf_AfterRender;
            Response.Redirect();

        }

        //private void Pdf_AfterRender(object sender, EventArgs e)
        //{
        //    HtmlToPdfResult result = HtmlToPdf.Result;

        //    //Save the conversion result to a file
        //    result.PdfDocument.Save("C:'\'C#_exercises'\'PDF_Printer");
        //}
    }
}