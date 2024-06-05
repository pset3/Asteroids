using System;
using UnityEngine;

namespace Asteroid
{
    public class Timer : IUpdatable, IDisposable
    {
        private float time;
        private readonly Game game;
        private float timer;
        private Action action;
        private bool isActive;
        private bool isReady;
        private bool isDisposed;

        public bool IsActive => isActive;
        public bool IsReady => isReady;
        public float Time => timer;

        public Timer(float time, Game game, Action action = null, bool autoStart = true, bool isReadyAtStart = false)
        {
            this.time = time;
            this.game = game;
            this.action = action;
            game.UpdateManager.Register(this);

            if (isReadyAtStart)
                isReady = true;

            if (!isReadyAtStart && autoStart)
                StartTimer();
        }

        public void StartTimer()
        {
            isActive = true;
            isReady = false;
            timer = time;
        }

        void IUpdatable.Update()
        {
            if (isActive)
            {
                if (!isReady)
                { 
                    timer -= UnityEngine.Time.deltaTime; 

                    if (timer <= 0f)
                    {
                        FinishTimer();
                    }
                }
            }
        }

        private void FinishTimer()
        {
            isActive = false;
            isReady = true;
            timer = 0;
            action?.Invoke();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    game.UpdateManager.Unregister(this);
                }

                isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}