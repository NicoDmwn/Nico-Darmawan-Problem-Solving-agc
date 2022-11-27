using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUspeedController : MonoBehaviour
    {
        public Collider2D ball;
        public float magnitude;
        public PowerUPManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivatePUspeed(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
