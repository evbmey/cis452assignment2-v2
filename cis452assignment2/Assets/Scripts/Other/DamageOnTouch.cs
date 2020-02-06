/*
* Evan Meyer
* DamageOnTouch.cs
* CIS452 Assignment 3
*/

using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DamageOnTouch : MonoBehaviour
{
    [SerializeField]
    private string tagToDamage;

    [SerializeField]
    private int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(tagToDamage))
        {
            Health health;
            if (collision.gameObject.TryGetComponent<Health>(out health))
            {
                health.HP -= damage;
                Destroy(gameObject);
            }
        }
    }
}
