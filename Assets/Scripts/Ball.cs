using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    float speedX;
    float speedY;

    public AudioSource audioOut;

    // Start is called before the first frame update
    void Start()
    {
        speedX = Random.Range(0, 2) == 0 ? -1: 1;
        speedY = Random.Range(0, 2) == 0 ? -1: 1;
        GetComponent<Rigidbody> ().velocity = new Vector3(Random.Range(5,10) * speedX, Random.Range(5, 10) * speedY, 0);
        
    }

    void OnTriggerEnter(Collider other) {

        speedX = Random.Range(0, 2) == 0 ? -1: 1;
        speedY = Random.Range(0, 2) == 0 ? -1: 1;
        GetComponent<Rigidbody> ().position = new Vector3(0, 0, 0);
        GetComponent<Rigidbody> ().velocity = new Vector3(Random.Range(5,10) * speedX, Random.Range(5, 10) * speedY, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }


    void OnCollisionEnter() {
       audioOut.Play(0); 
    }

}
