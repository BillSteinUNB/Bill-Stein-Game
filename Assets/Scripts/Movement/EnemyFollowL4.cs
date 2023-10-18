using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowL4 : MonoBehaviour
{
   private Transform target;
    public float speed;
    public bool CanMove = false;
    public Vector3 Spawn;
    public GameObject Player;
    public GameObject WDoor;
    public GameObject RDOOR;
    public Vector3 PSpawn;
    public bool towardsPlayer = true;
    void Start()
    {
        PSpawn = Player.transform.position;
        Spawn = transform.position;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {   
        //Debug.Log(Vector3.Distance(transform.position, Player.transform.position));
        if (Vector3.Distance(Spawn, transform.position) > 5)
        {            
            towardsPlayer = false;
        }
        else{
            if(Vector3.Distance(Spawn, transform.position) <0.5){
            towardsPlayer = true;}
        }  

        if(towardsPlayer == true){    
            if((Vector3.Distance(transform.position, Player.transform.position) < 6) && CanMove){
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
        else {
            transform.position = Vector2.MoveTowards(transform.position, Spawn, speed * Time.deltaTime);
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
            WDoor.SetActive(true);
            RDOOR.SetActive(true);
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
