using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickups : MonoBehaviour
{

public tring pickUPtype;
        public int amount;
        publice value;
        
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

    void OnTriggerEnter(collider other)
{
        if(oter.other.gameObject.CompareTag("player"))
        {
            Destroy(GameObject);// Destroy pickup
        }

}


