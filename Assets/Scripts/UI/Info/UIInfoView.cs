using System;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Text;

namespace Asteroid
{
    public class UIInfoView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;

        private StringBuilder stringBuilder = new StringBuilder();
        private Game game;

        public void Init(Game game)
        {
            this.game = game;
        }

        private void Update()
        {
            stringBuilder.Clear();
            stringBuilder.Append("Position: ");
            stringBuilder.AppendLine(game.Player.Model.Position.ToString());
            stringBuilder.Append("Rotation: ");
            stringBuilder.AppendLine(game.Player.Model.Rotation.ToString("0.00"));
            stringBuilder.Append("Speed: ");
            stringBuilder.AppendLine(game.Player.Model.Speed.ToString("0.00"));
            stringBuilder.Append("Laser Charge Count: ");
            stringBuilder.AppendLine(game.Player.Model.LaserCount.ToString());
            stringBuilder.Append("Reload Laser Time: ");
            stringBuilder.AppendLine(game.Player.Model.ReloadLaserTime.ToString("0.00"));
            text.text = stringBuilder.ToString();
        }
    }
}
