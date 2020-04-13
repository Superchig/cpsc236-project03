using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsGiver : MonoBehaviour
{
    public int pointsMod = 5;
    private Text scoreText;

    // Start is called before the first frame update
    private void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Player")
        {
            ScoreController.score += pointsMod;
            scoreText.GetComponent<ScoreController>().UpdateScore();
        }
    }
}
