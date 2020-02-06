/*
* Evan Meyer
* HighScoreDisplay.cs
* CIS452 Assignment 3
*/

using UnityEngine;

public class HighScoreDisplay : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Text highScoreText;

    [SerializeField]
    private IntReference highScore;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = highScore.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
