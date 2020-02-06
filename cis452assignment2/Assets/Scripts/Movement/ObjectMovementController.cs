/*
* Evan Meyer
* ObjectMovementController.cs
* CIS452 Assignment 3
*/

using UnityEngine;

public class ObjectMovementController : MonoBehaviour
{
    [SerializeField]
    private float speed = 3.0f;

    public void Move(float horizontal, float vertical)
    {
        if (horizontal == 0 && vertical == 0) return;

        Vector3 direction = new Vector3(horizontal, vertical);

        gameObject.transform.position += direction * speed;
    }

}
