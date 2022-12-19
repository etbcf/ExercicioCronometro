namespace ExercicioCronometro
{
    public class Cronometro
    {
        #region Atributos

        private DateTime _start;

        private DateTime _stop;

        private bool _isRunning;

        #endregion

        public void StartClock()
        {
            if (_isRunning)
                throw new InvalidOperationException("O cronómetro já está ligado!");

            _start = DateTime.Now;
            _isRunning = true;
        }

        public void StopClock()
        {
            if (!_isRunning)
                throw new InvalidOperationException("O cronómetro já está desligado!");

            _stop = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan GetTimeSpan()
        {
            return _stop - _start;
        }

        public bool ClockState()
        {
            return _isRunning;
        }

        public DateTime StartTime()
        {
            return _start;
        }
    }
}
