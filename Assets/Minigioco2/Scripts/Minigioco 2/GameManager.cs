using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigioco2
{
    public class GameManager : MonoBehaviour
    {
        public GameOverScreen GameOverScreen;

        public MainMenu MainMenuScreen;

        public void GameOver()
        {
            GameOverScreen.Setup();
        }

        void Start()
        {
            Time.timeScale = 1;
        }

        void Update()
        {

        }
    }
}
