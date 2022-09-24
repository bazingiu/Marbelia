using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Minigioco2
{
	public class TutorialScreen : MonoBehaviour 
	{
		void Awake () 
		{
			Time.timeScale = 0;
		}

		public void ButtonClicked()
		{
			GameObject tutorial = new GameObject();
			tutorial = GameObject.Find("Tutorial2") ;
			tutorial.SetActive(false);
			Time.timeScale = 1;  
		}
	}
}