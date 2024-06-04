using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{
    public class PlayerView : MovableObjectView
    {
        public new PlayerModel Model { get; private set; }
        public new PlayerController Controller { get; private set; }

        public void SetModel(PlayerModel model)
        {
            base.SetModel(model);
            Model = model;
        }

        public void SetController(PlayerController controller)
        {
            base.SetController(controller);
            Controller = controller;
        }

        protected override void Update()
        {
            base.Update();
            transform.rotation = Quaternion.Euler(0f, 0f, Model.Rotation);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            NPCView npc = collision.gameObject.GetComponent<NPCView>();

            if (npc != null)
            {
                Controller.Damage();
            }
        }
    }
}