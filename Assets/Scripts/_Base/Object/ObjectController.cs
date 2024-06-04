using System;

namespace Asteroid
{
    public class ObjectController : IUpdatable, IDisposable
    {
        public ObjectModel Model { get; private set; }
        protected ObjectView view;
        protected bool isDisposed;

        public ObjectController(ObjectModel model, ObjectView view)
        {
            Model = model;
            this.view = view;
            Game.AddObject(this);
            Game.UpdateManager.Register(this);
        }

        void IUpdatable.Update()
        {
            Update();
        }

        protected virtual void Update()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    Game.RemoveObject(this);
                    Game.UpdateManager.Unregister(this);
                    view.Destroy();
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