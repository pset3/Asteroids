using System;

namespace Asteroid
{
    public class ObjectController : IUpdatable, IDisposable
    {
        public ObjectModel Model { get; private set; }
        protected ObjectView view;
        protected bool isDisposed;
        private readonly Game game;

        public ObjectController(ObjectModel model, ObjectView view, Game game)
        {
            Model = model;
            this.view = view;
            this.game = game;
            game.AddObject(this);
            game.UpdateManager.Register(this);
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
                    game.RemoveObject(this);
                    game.UpdateManager.Unregister(this);
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