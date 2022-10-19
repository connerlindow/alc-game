using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public float speed;
    public float stopDistance;
    private Transform target;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObjrct.FindGameObjectWithTag("player").GetComponent<Transform>();//Refrence the player position
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stopDistance)
        {
            transform.position = Vector2.MoveTowards(Transform.position, target.position, speed * Time.deltaTime);// Moves the enemy twards the player 
        
        }
    }
}
