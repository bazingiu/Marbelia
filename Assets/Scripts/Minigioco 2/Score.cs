using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public Text invicible;
    private int isValid = 0;
    private float currentTime = 0.0f;

    private int maxPoint = 20;

    async void Update()
    {
        currentTime = Time.time;
       
        scoreText.text = player.points.ToString("0");  
        if (player.points ==maxPoint && player.points!=0 && !player.invicible){
            maxPoint +=20;
            StartCoroutine(PowerUp(3f));
        }
    }

    IEnumerator PowerUp (float duration){
        
        player.invicible  = true;
        invicible.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        player.invicible  = false;
        invicible.gameObject.SetActive(false);
    
    }
}
