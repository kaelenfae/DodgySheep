using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpy : MonoBehaviour


{
    public Rigidbody2D myRigidbody;
   
    public float MoveSpeed = 3f;
    public bool Flip = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)==true)    
            { 
                
                if (Flip==false)
                    { gameObject.transform.localScale = new Vector3(-1,1,1);
                        Flip = true;
                    }
                myRigidbody.velocity = Vector2.left * MoveSpeed;
         
            }
            if (Input.GetKeyDown(KeyCode.RightArrow)==true)    
            { 
                
                if (Flip==true)
                    { gameObject.transform.localScale = new Vector3(1,1,1);
                        Flip = false;
                    }
                myRigidbody.velocity = Vector2.right * MoveSpeed;
         
            }
    }
}
