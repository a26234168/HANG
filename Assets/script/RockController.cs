using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
   
    public string rockName = "JOHN";
    public float hunger = 10f;
    public float friendship = 100f;
    public bool isSick = false;

    float hungerScale = 2f;
    float friendScale = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        StatusUpdate();
        IsDead();
        
    }
    void StatusUpdate ()
    {
        hunger -=Time.deltaTime*hungerScale;
        friendship -= Time.deltaTime * hungerScale;

        int sickChance = Random.Range(0,1000);
        if (sickChance == 1)
        {
          
        }
        if (isSick == false)
        {
            hungerScale = 2f;
            friendScale = 2f;
        }
        else
        {
            hungerScale = 5f;
            friendScale = 5f;
        }
    }
    void IsDead()
    {
        if (hunger <= 0)
        {
            Destroy(gameObject);
        }
    }
}
