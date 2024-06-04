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

        public void Init()
        {
        }

        public override void Show()
        {
            scoreText.text = "SCORE: " + Game.Player.Model.Score.ToString();
            base.Show();
        }

        public void RestartGame()
        {
            Game.RestartGame();
        }
    }
}
