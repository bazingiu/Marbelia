using UnityEngine;
using System;
using UnityEngine.Audio;

public class CommandManager : MonoBehaviour
{
    public bool pauseOn;
    void Start()
    {
        if (!PlayerPrefs.HasKey("loaded"))
        {
            PlayerPrefs.SetInt("loaded", 0);
            PlayerPrefs.Save();
        }


        if (PlayerPrefs.GetInt("loaded") == 0)
        {
            GameObject tutorial = new GameObject();
            tutorial = GameObject.Find("Tutorialview");
            tutorial.SetActive(true);
            PlayerPrefs.SetInt("loaded", 1);
        }
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
