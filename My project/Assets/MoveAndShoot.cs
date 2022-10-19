using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    public float retreatDitance;
    private Transform target;
    private float shotDelay;
    public float startDelay;
    
    public GameObjectile;
    
    // Start is called before the first frame update
    void Start()
    {
        target =  GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
        shotDelay = startDelay;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector2.Distance(transform.position, .))
    }
}


