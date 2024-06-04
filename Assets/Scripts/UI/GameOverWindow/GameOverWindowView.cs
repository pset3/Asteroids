using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using TMPro;

namespace Asteroid
{
    public class GameOverWindowView : UIWindowView
    {
        [SerializeField] private TextMeshProUGUI scoreText;

        private StringBuilder stringBuilder = new StringBuilder();

        public void Init()
        {
        }

        public override void Show()
        {
            stringBuilder.Clear();
            stringBuilder.Append("SCORE: ");
            stringBuilder.Append(Game.Player.Model.Score);
            scoreText.text = stringBuilder.ToString();
            base.Show();
        }

        public void RestartGame()
        {
            Game.RestartGame();
        }
    }
}
