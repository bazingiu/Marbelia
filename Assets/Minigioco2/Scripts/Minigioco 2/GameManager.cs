using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Minigioco2
{
    public class GameManager : MonoBehaviour
    {
        public GameOverScreen GameOverScreen;

        public void GameOver()
        {
            GameOverScreen.Setup();
        }

        void Update()
        {

        }
 
    }
}
