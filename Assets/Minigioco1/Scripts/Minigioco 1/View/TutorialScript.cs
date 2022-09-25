using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class TutorialScript : MonoBehaviour 
{
	public CommandManager command;
	public GunManager gunManager;

	void Awake () 
	{
		gunManager.disableShoot();
		command.stopPauseControl();
        Time.timeScale = 0;
	}

	public void ButtonClicked()
    {
		command.startPauseControl();
		gunManager.enableShoot();
		GameObject tutorial = new GameObject();
		tutorial = GameObject.FindGameObjectWithTag("Tutorial") ;
    	tutorial.SetActive(false);
		Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
		Time.timeScale = 1;  
	}

}