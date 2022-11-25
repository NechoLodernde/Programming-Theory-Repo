using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameManager gameManager;
    [SerializeField] public int spawnLimit;
    private float rangeLimit = 10;
    private float yMaxLimit = 15;
    private float yMinLimit = 10;

    public void SetLimit()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        spawnLimit = 1;
    }

    public Vector3 GeneratePosition()
    {
        float rangeX = Random.Range(-rangeLimit, rangeLimit);
        float rangeY = Random.Range(yMinLimit, yMaxLimit);

        return new Vector3(rangeX, rangeY, 0);
    }

    public void SpawnObject()
    {
        int objectIndex = Random.Range(0, prefabs.Length);
 
        if(gameManager.isGameAlive == true && spawnLimit > 0)
        {
            Debug.Log("Will spawn");
            Instantiate(prefabs[objectIndex], GeneratePosition(), transform.rotation);
            spawnLimit--;
        }
    }
}
