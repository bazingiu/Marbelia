using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public static GameOverScript instance;
    public Text pointsText;

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
        int score = PointManager.instance.getScore();
        print("Score: " + score);
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }

    public void RestartButton()
    {   
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
