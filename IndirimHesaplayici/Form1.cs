namespace IndirimHesaplayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // form olu�tu�unda buras� �al���yor
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // butona her t�kland���nda bu metod �al���r
            // textbox'dan al�nan de�eri nas�l elde ederiz
            // name �zelli�i ile

            try
            {
                double tutar = Convert.ToDouble(txbTutar.Text);


                // en az birinin se�ili olmas�
                if (chkIndirim5.Checked || chkIndirim10.Checked || chkIndirim15.Checked)
                {
                    if (chkIndirim5.Checked)
                        tutar -= tutar * 0.05;

                    if (chkIndirim10.Checked)
                        tutar -= tutar * 0.1;

                    if (chkIndirim15.Checked)
                        tutar -= tutar * 0.15;
                }
                MessageBox.Show("Tutar: " + tutar);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("L�tfen harf, �zel karakterler kullanmay�n�z.");


            }
            catch (Exception exx)
            {
                MessageBox.Show("Hata: " + exx.Message);
            }

        }
    }
}