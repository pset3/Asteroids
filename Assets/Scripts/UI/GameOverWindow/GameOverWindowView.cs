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

        private Game game;
        private StringBuilder stringBuilder = new StringBuilder();

        public void Init(Game game)
        {
            this.game = game;
        }

        public override void Show()
        {
            stringBuilder.Clear();
            stringBuilder.Append("SCORE: ");
            stringBuilder.Append(game.Player.Model.Score);
            scoreText.text = stringBuilder.ToString();
            base.Show();
        }

        public void RestartGame()
        {
            game.RestartGame();
        }
    }
}
