/*
* Evan Meyer
* Stopwatch.cs
* CIS452 Assignment 3
*/

using UnityEngine;

public class Stopwatch : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Text textField;

    public float time = 0.0f;

    // Update is called once per frame
    public void Update()
    {
        time += Time.deltaTime;
        textField.text = Mathf.Round(time).ToString();
    }
}
