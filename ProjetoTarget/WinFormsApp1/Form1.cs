using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\kcedd\\Downloads\\dados.json");
            String getText = sr.ReadToEnd();

            List<Dados> getDados = JsonConvert.DeserializeObject<List<Dados>>(getText);

            for (int i = 0; i < getDados.Count; i++)
            {
                textBox1.Text += ("Dia: " + getDados[i].dia.ToString() + "\r\nValor: " + getDados[i].valor.ToString()) + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}