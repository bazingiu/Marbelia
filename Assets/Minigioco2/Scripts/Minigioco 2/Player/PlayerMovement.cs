using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigioco2
{
    public class PlayerMovement : MonoBehaviour
    {

        void Start()
        {

        }
        void Update()
        {
            var movement = Input.GetAxis("Vertical");
            transform.position += new Vector3(0, movement, 0) * Time.deltaTime * GameData.speedPlayer;
        }
    }
}
