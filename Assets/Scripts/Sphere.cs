using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(DestroyObject());
        }
    }

    protected virtual void SetMass()
    {
        gameObject.GetComponent<Rigidbody>().mass = 1;
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Will destroy");
        Destroy(gameObject);
        SpawnManager spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        spawnManager.SetLimit();
    }
}
