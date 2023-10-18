using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteSensorControllerL4 : MonoBehaviour
{
   public GameObject door;
    private Vector3 begin = new Vector3 (20.7f,-3.2f,0);
    private Vector3 end;
    private Vector3 difference;
    private float seconds = 0.4f;
    private bool close = true;
    public AudioSource source;
    public AudioClip DoorSlide;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("WhiteLight")){
            close = false;
            if (!source.isPlaying && (door.transform.position.x < 20.4f))
            {
                source.PlayOneShot(DoorSlide);
            }
            begin = door.transform.position;
            end = new Vector3 (19.6f,-2.8f,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(PressurePlateDoor.doorPassed == false){
            close = true;
        }
    }

    private void Update() {
        if(PressurePlateDoor.doorPassed == true){
            close = false;
        }

        if(close == true){
           begin = door.transform.position;
            end = new Vector3 (20.7f,-3.2f,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
    }
}
