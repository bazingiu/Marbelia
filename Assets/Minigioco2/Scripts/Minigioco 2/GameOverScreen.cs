using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

namespace Minigioco2
{
    public class GameOverScreen : MonoBehaviour
    {
        public void Awake()
        {
            GameObject.FindGameObjectWithTag("GameOver").SetActive(false);
        }
        /* per il punteggio, ma per ora lo commento */

        /*public void Setup (int score){
            gameObject.SetActive(true);
            pointsText.text = score.ToString() + " POINTS";
        }*/

        public void Setup()
        {
            gameObject.SetActive(true);
        }

        public void RestartButton()
        {
            SceneManager.LoadScene("Minigioco 2");
        }

        public void ExitButton()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
