using RestSharp;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ShortenUrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShorterUrl_Click(object sender, EventArgs e)
        {
            string longurl = TBInsertUrl.Text;

            try
            {
                var client = new RestClient("https://rel.ink/api/links/");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("url", longurl);
                IRestResponse response = client.Execute(request);
                //Console.WriteLine(response.Content);

                DatosJSON informe = new DatosJSON();

                informe = Newtonsoft.Json.JsonConvert.DeserializeObject<DatosJSON>(response.Content);
                TBHashId.Text= informe.hashid;
                TBLongUrl.Text = informe.url;
                TBCreatedAt.Text = informe.created_at;
                TBShortUrl.Text= "https://rel.ink/" + TBHashId.Text;
                linklbShortURL.Text = TBShortUrl.Text;
            }
            catch (Exception ex)
            {
                TBHashId.Text = ex.Message;
            }
           
        }

        private void linklbShortURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", linklbShortURL.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
