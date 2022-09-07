using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



void OnMouseDown()
    
    // Reduce clicks by one
    clickToPop -= 1;

    //Increase balloon volume
    transform.localScale += Vector3.one * scaleToIncrease;

    if(clickToPop == 0)
        
        //scoreManager.IncreaseScoreText(scoreToGive);