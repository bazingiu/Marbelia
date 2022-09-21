using UnityEngine;
using System;
using UnityEngine.Audio;

public class CommandManager : MonoBehaviour
{
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
         {
            Time.timeScale = 0;
            PauseGameScript.instance.Setup();
         }
    }
}
