namespace Practica_1
{
    public partial class Practica_1 : Form
    {
        private int horas = 0, minutos = 0, segundos = 0;
        private bool corriendo = false;
        public Practica_1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!corriendo)
            {
                tmrReloj.Start();
                corriendo = true;
                lblReloj.ForeColor = Color.Green;
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            lblReloj.ForeColor= Color.Red;
            tmrReloj.Stop();
            corriendo = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblReloj.ForeColor = Color.Black;
            tmrReloj.Stop();
            horas = minutos = segundos = 0;
            lblReloj.Text = "00:00:00";
            corriendo = false;
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
                if (minutos == 60)
                {
                    minutos = 0;
                    horas++;
                }
            }
            lblReloj.Text = horas.ToString("00") + ":" + minutos.ToString("00") + ":" + segundos.ToString("00");
        }
    }
}
