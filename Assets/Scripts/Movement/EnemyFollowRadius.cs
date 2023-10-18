using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyFollowRadius : MonoBehaviour
{
    private Transform target;
    public float speed;
    public bool CanMove = false;
    public GameObject Player;
    public float distance;
    public GameObject Stat;
    public GameObject S1;
    public Vector3 Spawn;
    public Vector3 S1Spawn;
    public Vector3 PSpawn;
    void Start()
    {  
        PSpawn = Player.transform.position;
        Spawn = transform.position;
        S1Spawn = S1.transform.position;
        speed = 3f;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void Update()
    {   
       distance = Vector2.Distance (Stat.transform.position, Player.transform.position);

        if(CanMove){
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }


        if(distance<= 6){
            CanMove = true;
        }
        else{
            CanMove = false;
        }

    }

    void OnTriggerEnter2D(Collider2D c)
    {  
        if(c.gameObject.tag == "WhiteLight"){
        speed = 0.3f;
        }
        if(c.gameObject.tag == "Hitbox"){
            transform.position = Spawn;
            Player.transform.position = PSpawn;
            S1.transform.position = S1Spawn;
        }
    }
    void OnTriggerStay2D(Collider2D c){
        if(c.gameObject.tag == "WhiteLight"){
        speed = 0.3f;
        }
    }
    void OnTriggerExit2D(Collider2D c)
    {
        if(c.gameObject.tag == "WhiteLight"){
        speed = 4f;
        }
    }
}
