/*
* Evan Meyer
* SpreadShot.cs
* CIS452 Assignment 3
*/

using UnityEngine;

public class SpreadShot : AttackBehavior
{
    [SerializeField]
    private GameObject projectilePrefab;

    public override void Attack()
    { 
        Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation * Quaternion.Euler(0, 0, 10));
        Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation * Quaternion.Euler(0, 0, 5));
        Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation * Quaternion.Euler(0, 0, -5));
        Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation * Quaternion.Euler(0, 0, -10));
    }
}
