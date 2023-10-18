using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform target;
    public float speed;
    public bool CanMove = true;
    public Vector3 Spawn;
    public GameObject Player;
    public Vector3 PSpawn;
    public GameObject S2;
    public Vector3 S2Spawn;
    void Start()
    {
        PSpawn = Player.transform.position;
        Spawn = transform.position;
        S2Spawn = S2.transform.position;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if(CanMove){
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }

    void OnTriggerEnter2D(Collider2D c)
    {  
        if(c.gameObject.tag == "WhiteLight"){
        CanMove = false;
        }

        if(c.gameObject.tag == "Hitbox"){
            transform.position = Spawn;
            Player.transform.position = PSpawn;
            S2.transform.position = S2Spawn;
        }
    }
    void OnTriggerStay2D(Collider2D c){
        if(c.gameObject.tag == "WhiteLight"){
        CanMove = false;
        }
    }
    void OnTriggerExit2D(Collider2D c)
    {
        if(c.gameObject.tag == "WhiteLight"){
        CanMove = true;
        }
    }
}
