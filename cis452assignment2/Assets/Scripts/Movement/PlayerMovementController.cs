/*
* Evan Meyer
* PlayerMovementController.cs
* CIS452 Assignment 3
*/

using UnityEngine;

[RequireComponent(typeof(ObjectMovementController))]
public class PlayerMovementController : MonoBehaviour
{
    private ObjectMovementController objectMovementController;

    public void Start()
    {
        objectMovementController = gameObject.GetComponent<ObjectMovementController>();
    }

    public void FixedUpdate()
    {
        objectMovementController.Move(Input.GetAxis("Horizontal") * Time.fixedDeltaTime, Input.GetAxis("Vertical") * Time.fixedDeltaTime);
    }
}
