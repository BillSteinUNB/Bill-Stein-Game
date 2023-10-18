using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLvl2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject S2;
    public GameObject S1;
    public Vector3 S2Spawn;
    public Vector3 S1Spawn;
    public Vector3 PSpawn;
    // Start is called before the first frame update
    void Start()
    {
        PSpawn = Player.transform.position;
        S1Spawn = S1.transform.position;
        S2Spawn =  S2.transform.position;
    }

    void OnTriggerEnter2D(Collider2D c){
        if(c.gameObject.tag == "Hitbox"){
            Player.transform.position = PSpawn;
            S1.transform.position = S1Spawn;
            S2.transform.position = S2Spawn;
        }
    }
}
