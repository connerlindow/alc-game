using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickups : MonoBehaviour
{

    public string pickUPtype;
    public int amount;
    public value;
        
        private GameManager gm;
        
        
    // Start is called before the first frame update
         
    
        
    
    
    
    void Start()
    {
       gm = GameObject.Find("GameManager")
       .GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.GameObject.CompareTag("player"))
        {
            Destroy(gameObject);// Destroy pickup
        }
    }

        

}


