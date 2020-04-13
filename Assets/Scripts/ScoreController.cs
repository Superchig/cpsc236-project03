using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static int score = 0;


    // Start is called before the first frame update
    public void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        GetComponent<Text>().text = "Score: " + score;
    }
}
