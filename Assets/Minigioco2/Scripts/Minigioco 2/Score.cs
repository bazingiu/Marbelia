using Google.Protobuf.WellKnownTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigioco2
{
    public class Score : MonoBehaviour
    {
        public Player player;
        public Text scoreText;
        public Text invicible;
        private float currentTime = 0.0f;

        private int maxPoint = 20;

        delegate void MultiDelegate();
        MultiDelegate myMultiDelegate;

        async void Update()
        {
            currentTime = Time.time;

            scoreText.text = player.points.ToString("0");
            if (player.points == maxPoint && player.points != 0 && !player.invicible)
            {
                maxPoint += 20;
                StartCoroutine(PowerUp(3f));
            }
        }

        IEnumerator PowerUp(float duration)
        {
            myMultiDelegate += setInvicibleActive;
            myMultiDelegate += setInvicibleTextActive;
            if (myMultiDelegate != null)
            {
                myMultiDelegate();
            }
            yield return new WaitForSeconds(duration);
            player.invicible = false;
            invicible.gameObject.SetActive(false);
        }
        void setInvicibleActive()
        {
            player.invicible = true;
        }

        void setInvicibleTextActive()
        {
            invicible.gameObject.SetActive(true);
        }
    }
}
