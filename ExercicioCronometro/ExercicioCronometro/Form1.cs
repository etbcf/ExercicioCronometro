namespace ExercicioCronometro
{
    public partial class frmPrincipal : Form
    {
        private readonly Cronometro _cronometro;

        public frmPrincipal()
        {
            InitializeComponent();
            _cronometro = new Cronometro();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (_cronometro.ClockState())
            {
                _cronometro.StopClock();
                btnOnOff.Text = "Liga";
                TimerRelogio.Enabled = false;
                //lblContador.Text = _cronometro.GetTimeSpan().ToString();
            }
            else
            {
                _cronometro.StartClock();
                btnOnOff.Text = "Desliga";
                TimerRelogio.Enabled = true;
            }
        }

        private void UpdateLabel()
        {
            var tempo = DateTime.Now - _cronometro.StartTime();
            lblContador.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3}", tempo.Hours, tempo.Minutes, tempo.Seconds, tempo.Milliseconds);
        }

        private void TimerRelogio_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }
    }
}