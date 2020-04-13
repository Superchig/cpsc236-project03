using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = 
                "Congratulations! You've beaten the level!\n" +
                "Your score is " + ScoreController.score + ".\n" +
                "The game is now over.";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
