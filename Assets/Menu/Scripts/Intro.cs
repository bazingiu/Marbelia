using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
	public GameObject into = new GameObject();
    void Awake () 
	{
        into = GameObject.FindGameObjectWithTag("into") ;
        into.SetActive(true);
	}

	public void ButtonClicked()
    {
    	into.SetActive(false);
		Time.timeScale = 1;  
	}
}
