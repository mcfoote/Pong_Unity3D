using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    int p1Score;
    int p2Score;

    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;

    

    // Start is called before the first frame update
    void Start()
    {
        p1Score = 0;
        p2Score = 0;


        Text1.text = p1Score.ToString();
        Text2.text = p2Score.ToString();
        
    }

    void OnTriggerEnter(Collider other) {


        if(this.gameObject.name == "Goal2") {
            p2Score += 1;
            Text2.text = p2Score.ToString();
            Debug.Log("Score Goal 2");
        }
        
        if(this.gameObject.name == "Goal1") {
            p1Score += 1;
            Text1.text = p1Score.ToString();
            Debug.Log("Score Goal 1");
        }

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
