using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGameScript : MonoBehaviour
{
   public static PauseGameScript instance;

   void Start()
   {
        gameObject.SetActive(false);   
   }

    void Awake()
    {
        instance = this;
    }

    public void Setup()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 
        gameObject.SetActive(true);
        print(gameObject);
    }

    public void CursorMode()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false; 
        gameObject.SetActive(false);
    }

    // Fa tornare alla partita
    public void BackToGame()
    {   
        CursorMode();
    }

    // Fa ricominciare la partita da zero
    public void RestartButton()
    {   
        CursorMode();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Fa tornare al menu principale
    public void ExitButton()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    // Permette di gestire le impostazioni
    public void OptionButton()
    {
    }
}