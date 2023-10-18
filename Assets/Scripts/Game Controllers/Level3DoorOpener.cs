using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Level3DoorOpener : MonoBehaviour
{
    public bool laserOnSensor = false;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.x >= 16f && Player.transform.position.x <= 17f && Player.transform.position.y >= 1.3f){
            if(laserOnSensor == true){
                SceneManager.LoadScene (sceneName:"Level 4");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D c){
        StartCoroutine(DoorOpened());
    }
    void OnTriggerExit2D(Collider2D c){
        StartCoroutine(DoorClosed());
    }

    IEnumerator DoorOpened(){
        yield return new WaitForSecondsRealtime(1);
        laserOnSensor = true;
    }
    IEnumerator DoorClosed(){
        yield return new WaitForSecondsRealtime(4);
        laserOnSensor = false;
    }
}
