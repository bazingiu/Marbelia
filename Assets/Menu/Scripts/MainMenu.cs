using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Minigame1()
    {
        SceneManager.LoadScene("Minigioco1");
    }
    public void Minigame2()
    {
        SceneManager.LoadScene("Minigioco2");
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
