using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public static GameOverScript instance;

    public GunManager gunManager;
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
        gunManager.disableShoot();
        Cursor.lockState = CursorLockMode.None; 
        int score = PointManager.instance.getScore();
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }

    public void RestartButton()
    {   
        gunManager.enableShoot();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
