using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    //[SerializeField] protected List<breakableBrick> bricks;
    [SerializeField] protected GameObject canvasScene;
    protected GameManager gameManager;

    private void Awake()
    {
        RoundManager[] gameObjects = FindObjectsOfType<RoundManager>();

        if (gameObjects.Length > 1)
        {
            Destroy(gameObject);
        }

    }

    /*public void RemoveBrick(breakableBrick brick)
    {
        if (bricks.Count > 0)
        {
            bricks.Remove(brick);
        }

        EndRound();

    }*/

    protected void EndRound()
    {

        //if (bricks.Count <= 0)
        if(FindObjectsOfType<breakableBrick>().Length < 1)
        {
            canvasScene.SetActive(true);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        if (gameManager == null)
        {
            gameManager = GameManager.Instance;
        }
        else
        {
            Destroy(gameObject);
        }
        //gameManager = new GameManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
