using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{
    public class UpdateManager : MonoBehaviour
    {
        public bool IsPaused { get; set; }
        private List<IUpdatable> updatables = new List<IUpdatable>();

        public void Register(IUpdatable updatable)
        {
            updatables.Add(updatable);
        }

        public void Unregister(IUpdatable updatable)
        {
            updatables.Remove(updatable);
        }

        private void Update()
        {
            if (IsPaused)
                return;

            for (int i = 0; i < updatables.Count; i++)
            {
                updatables[i].Update();
            }
        }

        public void Pause()
        {
            IsPaused = true;
        }

        public void Unpause()
        {
            IsPaused = false;
        }
    }
}