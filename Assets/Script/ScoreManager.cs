using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightscore;
    public int leftscore;

    public int Maxscore;

    public BallController ball;

    public void Addleftscore(int increment)
    {
        leftscore += increment;
        ball.ResetBall();

        if (leftscore >= Maxscore)
        {
            Gameover();
        }
    }

    public void Addrightscore(int increment)
    {
        rightscore += increment;
        ball.ResetBall();

        if (rightscore >= Maxscore)
        {
            Gameover();
        }
    }

    public void Gameover()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
