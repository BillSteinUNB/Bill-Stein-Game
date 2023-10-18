using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Stat1;
    public GameObject Stat2;
    public Vector3 PSpawn;
    public Vector3 S1Spawn;
    public Vector3 S2Spawn;
    // Start is called before the first frame update
    void Start()
    {
        PSpawn = transform.position;
        S1Spawn = Stat1.transform.position;
        S2Spawn = Stat2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D c){
        if(c.gameObject.tag == "Statue"){
            transform.position = PSpawn;
            Stat1.transform.position = S1Spawn;
            Stat2.transform.position = S2Spawn;
        }
    }
}
