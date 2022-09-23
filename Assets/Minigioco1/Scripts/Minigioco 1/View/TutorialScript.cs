using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour 
{
	public CommandManager command;
	public Gun gun;
	public Gun mp5;

	void Awake () 
	{
		command.stopPauseControl();
		gun.disableShoot();
		mp5.disableShoot();
        Time.timeScale = 0;
	}

	public void ButtonClicked()
    {
		command.startPauseControl();
		gun.enableShoot();
		mp5.enableShoot();
		GameObject tutorial = new GameObject();
		tutorial = GameObject.FindGameObjectWithTag("Tutorial") ;
    	tutorial.SetActive(false);
		Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
		Time.timeScale = 1;  
	}

}