/*
* Evan Meyer
* EnemyMovementController.cs
* CIS452 Assignment 3
*/

using UnityEngine;

[RequireComponent(typeof(ObjectMovementController))]
public class EnemyMovementController : MonoBehaviour
{
    private ObjectMovementController objectMovementController;
    private Transform playerTransform;

    public void Start()
    {
        objectMovementController = gameObject.GetComponent<ObjectMovementController>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void FixedUpdate()
    {
        if (playerTransform is Object)
        {
            Vector3 movementAngle = Vector3.Normalize(playerTransform.position - gameObject.transform.position);

            objectMovementController.Move(movementAngle.x * Time.fixedDeltaTime, movementAngle.y * Time.fixedDeltaTime);
        }
    }
}
