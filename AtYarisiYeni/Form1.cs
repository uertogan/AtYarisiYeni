using WMPLib;

namespace AtYarisiYeni
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int kosus = 0;

        public Form1()
        {
            InitializeComponent();
            player.settings.volume = 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kosus++;
            at1.Left += rnd.Next(1, 15);
            at2.Left += rnd.Next(1, 15);
            at3.Left += rnd.Next(1, 15);
        
            #region En �ndeki At�n Bulunmas�
            PictureBox ondeki = at1;

            if (at2.Left > ondeki.Left)
            {
                ondeki = at2;
            }
            if (at3.Left > ondeki.Left)
            {
                ondeki = at3;
            }
            #endregion

            if (kosus > 10)
                lblSpiker.Text = ondeki.Tag + " nolu at yar��� �nde g�t�r�yor.. ";

            #region Biti� Kontrol�
            if (ondeki.Right > bitis.Left)
            {
                timer1.Stop();
                lblSpiker.Text = ondeki.Tag + " nolu at yar��� kazand�.";
                player.URL = "Sesler/zil.mp3";
                MessageBox.Show("Oyun Bitti");
                YeniOyun();
            }
            #endregion
        }

        private void YeniOyun()
        {
            kosus = at1.Left = at2.Left = at3.Left = 0;
            btnBaslat.Show();
            lblSpiker.Text = "Atlar yar��a haz�r..";

        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblSpiker.Text = "ve yar�� ba�lad�..";
            player.URL = "Sesler/tufek.mp3";
            btnBaslat.Hide();
        }
    }
}
