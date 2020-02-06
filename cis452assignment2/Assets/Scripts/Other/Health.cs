/*
* Evan Meyer
* Health.cs
* CIS452 Assignment 3
*/

using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int hp;

    [SerializeField]
    private UnityEvent deathBehavior;

    public int HP
    {
        get => hp;
        set 
        {
            hp = value;
            if(hp <= 0)
            {
                deathBehavior.Invoke();
            }
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

}
