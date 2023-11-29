using System;

namespace prct_6
{
    internal class Trial
    {
        public event Action<string> TrialEvent;
        public void StartTrial()
        {
            TrialEvent?.Invoke("Почалось тестове випробування на роботі");
        }
    }
}