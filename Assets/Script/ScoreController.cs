//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorkiri;
    public Text skorkanan;

    public ScoreManager manager;
    
    private void Update()
    {
        skorkiri.text = manager.leftscore.ToString();
        skorkanan.text = manager.rightscore.ToString();
    }

}
