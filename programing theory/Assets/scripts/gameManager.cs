using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    [SerializeField] GameObject[] colorPrefabs;
    [SerializeField] float spawnRangeX = 15f;
    [SerializeField] float spawnPosZ = 20f;
    [SerializeField] float startDelay = 2;
    [SerializeField] float spawnInterval = 1.5f;

    [SerializeField] bool gameIsOn;


    public int lives;
    [SerializeField] TextMeshProUGUI livesText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "lives: " + lives;

        if (lives == 0)
        {
            Debug.Log("gameover");
            GameOver();
        }
    }

    void SpawnRandomColor()
    {
        int colorIndex = Random.Range(0, colorPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(colorPrefabs[colorIndex], spawnPos, colorPrefabs[colorIndex].transform.rotation);
    }

    public void StartGame()
    {
        gameIsOn = true;
        lives = 3;
        
        
            InvokeRepeating("SpawnRandomColor", startDelay, spawnInterval);
        
        
        GameObject.Find("game over").SetActive(false);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }

}
