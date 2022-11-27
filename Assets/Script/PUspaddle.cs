using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUspaddle : MonoBehaviour
{
    public Collider2D ball;
    public float magnitude;
    public PowerUPManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<PaddleController>().Activatepaddlespeed(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
