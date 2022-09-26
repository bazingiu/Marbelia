using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public static WinScript instance;
	public CommandManager command;
    public Gun gun;
	public Gun mp5;
    GameObject win; 
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        win = GameObject.FindGameObjectWithTag("Win");
        win.SetActive(false);
    }
	public void display() 
	{
        win.SetActive(true);
		command.stopPauseControl();
        Time.timeScale = 0;
        gun.disableShoot();
		mp5.disableShoot();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 
	}

	public void ButtonClicked()
    {
        SceneManager.LoadScene("Mainmenu");
	}
}
