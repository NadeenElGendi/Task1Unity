using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movee : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { movement();
        
    }
    void movement(){

        float x=Input.GetAxis("Horizontal");
        float mov=speed*x*-1;
        body.velocity=new Vector2(mov,body.velocity.y);
       
        
    }
}
