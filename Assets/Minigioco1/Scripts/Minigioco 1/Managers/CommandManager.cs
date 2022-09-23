using UnityEngine;
using System;
using UnityEngine.Audio;

public class CommandManager : MonoBehaviour
{
    public bool pauseOn; 
    void Start()
    {
        GameObject tutorial = new GameObject();
        tutorial = GameObject.Find("Tutorialview");
        tutorial.SetActive(true);
    }
    public void stopPauseControl()
    {
        pauseOn = false; 
    }

    public void startPauseControl()
    {
        pauseOn = true; 
    }
    void Update()
    {
        if (pauseOn == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                PauseGameScript.instance.Setup();
            }
        }
    }
}
