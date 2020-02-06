/*
* Evan Meyer
* AttackHandler.cs
* CIS452 Assignment 3
*/

using UnityEngine;

[RequireComponent(typeof(SingleShot), typeof(SpreadShot))]
public class AttackHandler : MonoBehaviour
{
    private AttackBehavior attackBehavior;

    public void Start()
    {
        attackBehavior = GetComponent<SingleShot>();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            attackBehavior = GetComponent<SingleShot>();
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            attackBehavior = GetComponent<SpreadShot>();
        }

        if(Input.GetMouseButtonDown(0))
        {
            HandleAttack();
        }
    }

    public void HandleAttack()
    {
        attackBehavior.Attack();
    }
}
