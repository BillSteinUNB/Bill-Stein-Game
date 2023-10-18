using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl4Fix : MonoBehaviour
{
    public GameObject WDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D c){
        if(c.gameObject.tag == "WhiteLight"){
            StartCoroutine(DeleteDoor());
        }
    }

    IEnumerator DeleteDoor(){
    yield return new WaitForSecondsRealtime(5);
    WDoor.SetActive(false);
    }
}
