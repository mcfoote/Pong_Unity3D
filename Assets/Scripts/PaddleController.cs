using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = .05f;
        if(gameObject.name == "Paddle1") {
            transform.Translate(0, Input.GetAxis("Horizontal") * speed, 0);
        }
            
        else  {
            transform.Translate(0, Input.GetAxis("Vertical") * speed, 0);
        } 
            
        
    }
}
