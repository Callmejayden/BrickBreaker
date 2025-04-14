using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakableBrick : MonoBehaviour
{

    [SerializeField,Range(1,20)]protected int maxHealth = 1; 
    [SerializeField] protected int curHealth;

    private void Awake()
    {
        curHealth = maxHealth;
    }

    public void Break(int aDamage)
    {
        curHealth -= aDamage; 
        TryBreakBrick();
    }

    protected void TryBreakBrick()
    {
        if (curHealth <= 1)
        {
            //FindObjectOfType<RoundManager>().RemoveBrick(this);
            GameManager.Instance.AddScore(maxHealth);
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
