/*
* Evan Meyer
* HighScoreSetter.cs
* CIS452 Assignment 3
*/

using UnityEngine;

public class HighScoreSetter : MonoBehaviour
{
    [SerializeField]
    private IntReference highScore; 

    private Stopwatch stopwatch;

    public void Start()
    {
        stopwatch = FindObjectOfType<Stopwatch>();
    }

    public void SetHighScore()
    {
        if(stopwatch.time > highScore.value)
        {
            highScore.value = Mathf.RoundToInt(stopwatch.time);
        }
    }
}
