using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.IO;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainUIManager : MonoBehaviour
{
    public GameObject TitleScreen;
    public GameObject MainScreen;
    public GameManager gameManager;
    public SpawnManager spawnManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    public void Play()
    {
        gameManager.StartGame();
        spawnManager.SetLimit();
        TitleScreen.SetActive(false);
        MainScreen.SetActive(true);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void Return()
    {
        gameManager.isGameAlive = false;
        TitleScreen.SetActive(true);
        MainScreen.SetActive(false);
    }

    public void SpawnIt()
    {
        
        if(gameManager.isGameAlive == true && spawnManager.spawnLimit > 0)
        {
            Debug.Log("Spawn Limit is 1");
            spawnManager.SpawnObject();
        }
    }
}
