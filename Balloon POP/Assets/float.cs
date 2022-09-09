using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class float : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperBound = 25.0f;
    private Balloon balloon;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

        balloon= GetCompoent<Balloon>(); // reference balloon
        
        
        
    // Update is called once per frame
    void Update()
    {
        
        
        transform.Translate(Vector3.up * Time.deltaTime)
        
        
        if(transform.position.y > upperBound)
        
        
            Destroy(gameOject);
    }
}
