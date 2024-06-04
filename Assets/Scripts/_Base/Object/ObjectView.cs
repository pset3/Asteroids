using UnityEngine;

namespace Asteroid
{
    public class ObjectView : MonoBehaviour
    {
        public ObjectModel Model { get; private set; }
        public ObjectController Controller { get; private set; }

        public virtual void SetModel(ObjectModel model)
        {
            Model = model;
        }

        public virtual void SetController(ObjectController controller)
        {
            Controller = controller;
        }

        protected virtual void Update()
        {
        }

        public virtual void Destroy()
        {
            Destroy(gameObject);
        }
    }
}