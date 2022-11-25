using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameAlive;
    [SerializeField] private int m_SpawnLimit;
    public int SpawnLimit
    {
        get
        {
            return m_SpawnLimit;
        }

        set
        {
            m_SpawnLimit = 1;
        }

    }
    
    public void StartGame()
    {
        SpawnLimit = 1;
        Debug.Log("How many? " + SpawnLimit);
        Debug.Log("How much? " + m_SpawnLimit);
        isGameAlive = true;
    }
    
}
