// Jayden Overdahl
// 2/1/2025

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
