//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class GoalControll : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;

    public ScoreManager manager;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (isRight)
            {
                manager.Addrightscore(1);
            }
            else
            {
                manager.Addleftscore(1);
            }
        }
    }
}
