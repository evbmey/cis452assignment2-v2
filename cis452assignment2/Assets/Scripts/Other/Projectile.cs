/*
* Evan Meyer
* Projectile.cs
* CIS452 Assignment 3
*/

using UnityEngine;

[RequireComponent(typeof(ObjectMovementController))]
public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float duration;

    private ObjectMovementController objectMovementController;
    private Vector3 angle;

    // Start is called before the first frame update
    void Start()
    {
        objectMovementController = GetComponent<ObjectMovementController>();
        angle = gameObject.transform.right;
    }

    // Update is called once per frame
    public void Update()
    {
        if(duration <= 0)
        {
            Destroy(gameObject);
        }

        duration -= Time.deltaTime;
    }

    public void FixedUpdate()
    {
        objectMovementController.Move(angle.x * Time.fixedDeltaTime, angle.y * Time.fixedDeltaTime);
    }
}
