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
		gun.enableShoot();
		mp5.enableShoot();
        Time.timeScale = 0;
	}

	public void ButtonClicked()
    {
		command.startPauseControl();
		gun.enableShoot();
		mp5.disableShoot();
		GameObject tutorial = new GameObject();
		tutorial = GameObject.FindGameObjectWithTag("Tutorial") ;
    	tutorial.SetActive(false);
		Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
		Time.timeScale = 1;  
	}

}