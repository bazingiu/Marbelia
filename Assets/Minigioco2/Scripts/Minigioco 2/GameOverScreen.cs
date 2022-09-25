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

        public void Setup()
        {
            gameObject.SetActive(true);
        }

        public void RestartButton()
        {
            SceneManager.LoadScene("Minigioco2");
        }

        public void ExitButton()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
