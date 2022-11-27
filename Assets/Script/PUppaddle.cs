using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUppaddle : MonoBehaviour
{
    public Collider2D ball;
    public int newSize;
    public PowerUPManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<PaddleController>().SetPaddleSize(newSize);
            manager.RemovePowerUp(gameObject);
        }
    }
}
