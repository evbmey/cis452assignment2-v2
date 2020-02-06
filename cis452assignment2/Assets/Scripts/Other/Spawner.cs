/*
* Evan Meyer
* Spawner.cs
* CIS452 Assignment 3
*/

using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnedObject;

    [SerializeField]
    private int initialDelay;

    [SerializeField]
    private int spawnDelay;

    private System.Random random = new System.Random(System.DateTime.Now.Millisecond);

    void Start()
    {
        StartCoroutine("Spawn");
        StartCoroutine("ReduceDelay");
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(initialDelay);

        while (true)
        {
            Instantiate(spawnedObject, gameObject.transform.position + new Vector3(random.Next(-5,5), random.Next(-5, 5)) , gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnDelay + random.Next(0, 3));
        }       
    }

    IEnumerator ReduceDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            if (spawnDelay > 0) spawnDelay--;
        }
    }
}
