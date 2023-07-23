using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSpawning : MonoBehaviour
{
    public GameObject Boulder;
    public float spawnRate = 2;
    public float SpawnOffset = 10;
    
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnBoulder();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        { timer += Time.deltaTime;
        
        }else
        {
            spawnBoulder();
        
            timer = 0;
        }
        
    }
    void spawnBoulder()
    {   
        float limitLeft = transform.position.x - SpawnOffset;
        float limitRight = transform.position.x + SpawnOffset;
        Instantiate(Boulder, new Vector3(Random.Range(limitLeft,limitRight),transform.position.y,0), transform.rotation);}
}
