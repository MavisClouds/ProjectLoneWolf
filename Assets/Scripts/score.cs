using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int scores;        // The player's score.


    public Text scoreText;
    public Text scoreone;
    // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.

        // Reset the score.
        scores = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        scoreText.text = "" + scores;
        scoreone.text = "" + scores;
    }
}
