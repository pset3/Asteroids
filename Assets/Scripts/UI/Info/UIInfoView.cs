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

        public void Init()
        {
        }

        private void Update()
        {
            stringBuilder.Clear();
            stringBuilder.Append("Position: ");
            stringBuilder.AppendLine(Game.Player.Model.Position.ToString());
            stringBuilder.Append("Rotation: ");
            stringBuilder.AppendLine(Game.Player.Model.Rotation.ToString("0.00"));
            stringBuilder.Append("Speed: ");
            stringBuilder.AppendLine(Game.Player.Model.Speed.ToString("0.00"));
            stringBuilder.Append("Laser Charge Count: ");
            stringBuilder.AppendLine(Game.Player.Model.LaserCount.ToString());
            stringBuilder.Append("Reload Laser Time: ");
            stringBuilder.AppendLine(Game.Player.Model.ReloadLaserTime.ToString("0.00"));
            text.text = stringBuilder.ToString();
        }
    }
}
