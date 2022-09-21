using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameOverScreen GameOverScreen;

    public void GameOver(){
        GameOverScreen.Setup();
    }
    void Start()
    {
        Time.timeScale = 1;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
