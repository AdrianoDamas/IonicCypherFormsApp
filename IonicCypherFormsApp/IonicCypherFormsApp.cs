namespace IonicCypherFormsApp
{
    public partial class IonicCypherFormsApp : Form
    {
        public IonicCypherFormsApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cıktı = "";
            int satır, sutun, i;
            string metin = textBox1.Text.ToLower();
            for (i = 0; i < metin.Length; i++)
            {
                if (metin[i] == ' ') // boşluk karakteri bulma
                {
                    cıktı = cıktı.Substring(0, cıktı.Length - 1);
                    cıktı += " ";

                    continue;
                }
                satır = (int)Math.Floor((metin[i] - 'a') / 5.0) + 1; // satır sırası bulma

                sutun = (int)((metin[i] - 'a') % 5) + 1; // sutun sırası bulma

                if (metin[i] == 'k') // karakterin k harfi olma durumu
                {
                    satır = satır - 1;
                    sutun = 6 - sutun;
                }
                else if (metin[i] >= 'j') // karakterin j den büyük olma durumu
                {
                    if (sutun == 1)
                    {
                        sutun = 6;
                        satır = satır - 1;
                    }
                    sutun = sutun - 1;
                }
                string Ssatır = Convert.ToString(satır);
                string Ssutun = Convert.ToString(sutun);
                cıktı += Ssatır + Ssutun + "-";
            }
            textBox2.Text = cıktı.Substring(0, cıktı.Length - 1);
        }
    }
}