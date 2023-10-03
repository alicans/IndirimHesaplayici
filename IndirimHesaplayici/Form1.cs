namespace IndirimHesaplayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // form oluþtuðunda burasý çalýþýyor
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // butona her týklandýðýnda bu metod çalýþýr
            // textbox'dan alýnan deðeri nasýl elde ederiz
            // name özelliði ile

            try
            {
                double tutar = Convert.ToDouble(txbTutar.Text);


                // en az birinin seçili olmasý
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

                MessageBox.Show("Lütfen harf, özel karakterler kullanmayýnýz.");


            }
            catch (Exception exx)
            {
                MessageBox.Show("Hata: " + exx.Message);
            }

        }
    }
}