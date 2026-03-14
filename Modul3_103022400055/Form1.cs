namespace Modul3_103022400055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #Muhammad_Radhi_Haidar_Rafi
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cbDari.SelectedItem == null || cbKe.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
                return;
            }

            if (string.IsNullOrEmpty(txtInput.Text) || !double.TryParse(txtInput.Text, out double nilaiAwal)) 
            {
                MessageBox.Show("Masukkan angka yang valid");
                return;
            }

            double celcius = 0;

            string satuanAsal = cbDari.SelectedItem.ToString();
            string satuanTujuan = cbKe.SelectedItem.ToString();

            switch (satuanAsal)
            {
                case "Celcius":
                    celcius = nilaiAwal;
                    break;

                case "Fahrenheit":
                    celcius = (nilaiAwal - 32) * 5 / 9;
                    break;

                case "Kelvin":
                    celcius = nilaiAwal - 273.15;
                    break;

                case "Reamur":
                    celcius = nilaiAwal * 5 / 4;
                    break;
            }

            double hasil = 0;

            switch (satuanAsal)
            {
                case "Celcius":
                    hasil = celcius;
                    break;

                case "Fahrenheit":
                    hasil = (celcius * 9 / 5) + 32;
                    break;

                case "Kelvin":
                    hasil = celcius + 273.15;
                    break;

                case "Reamur":
                    hasil = celcius * 4 / 5;
                    break;
            }

            txtHasil.Text = hasil.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbKe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
