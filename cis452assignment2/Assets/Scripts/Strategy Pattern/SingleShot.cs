/*
* Evan Meyer
* SingleShot.cs
* CIS452 Assignment 3
*/

using UnityEngine;

public class SingleShot : AttackBehavior
{
    [SerializeField]
    private GameObject projectilePrefab;

    public override void Attack()
    {
        Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
