// Jayden Overdahl
// 2/1/2025

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    private static GameManager instance;
    private float playerScore = 0;


    public float PlayerScore
    {
        get
        {
            return playerScore;
        }
        set
        {
            playerScore = value;
        }
    }

    public void ResetScore()
    {
        playerScore = 0;
    }

    public void AddScore(float score)
    {
        playerScore += score;
    }

    public void NextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex >= SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        if (nextSceneIndex == 1)
        {
            ResetScore();
        }
    }
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }


    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject aGO = new GameObject("GameManager");
                instance = aGO.AddComponent<GameManager>();
                DontDestroyOnLoad(aGO);
            }
            return instance;
        }
    }

}
