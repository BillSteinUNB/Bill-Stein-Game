using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateDoor : MonoBehaviour
{
    public GameObject p1;
    public static bool doorPassed = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
            
            if (other.gameObject.tag == "Player"){
                doorPassed = true;
                print("col");
            }
        }
}
