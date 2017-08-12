using LotoFacil.Business;
using LotoFacil.Model;
using LotoFacil.Model.Lotofacil;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoFacil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string html = string.Empty;
            string url = @"https://confiraloterias.com.br/api/json/?loteria=lotofacil&token=9j7jvYVmdNhLOxL";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            LotoFacilBusiness lotoFacilBusiness = new LotoFacilBusiness();
            lotoFacilBusiness.teste();
        }
    }
}
