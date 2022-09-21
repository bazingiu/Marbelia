using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour{
    /* per il punteggio, ma per ora lo commento */
    
    /*public void Setup (int score){
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }*/

    public void Setup (){
        gameObject.SetActive(true);
    }

    public void RestartButton (){
        SceneManager.LoadScene("Minigioco 2");
    }

    public void ExitButton(){
        //SceneManager.LoadScene("MainMenu");
    }
}
