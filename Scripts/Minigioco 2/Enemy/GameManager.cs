using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameOverScreen GameOverScreen;

    bool pause = false;

    public void GameOver(){
        GameOverScreen.Setup();
    }

    public void mainMenu(){
        pause = !pause;
        if (pause == false)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    void Start()
    {
        Time.timeScale = 1;   
    }

    void Update()
    {
        
    }
}
