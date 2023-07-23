using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float RotSpeed = 0.1f;
    public float dropSpeed = 0.1f;
    public float deadZone = -5;
   public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,RotSpeed));
        transform.position = transform.position + Vector3.down * dropSpeed * Time.deltaTime;
        if (transform.position.y < deadZone)
        {
            Debug.Log("BoulderGone");
            Destroy(gameObject);
        }

    }
   void OnTriggerEnter2D(Collider2D collision)
{
     Debug.Log("Boulder Collided");
     Destroy(gameObject);
        
     logic.addScore();
   }
    void OnCollisionEnter2D(Collision2D collision)
{
     Debug.Log("Boulder Sheepd");
     Destroy(gameObject);
        
     logic.subtractScore();
   }
}
