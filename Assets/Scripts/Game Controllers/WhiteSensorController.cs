using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteSensorController : MonoBehaviour
{
   public GameObject door;
    private Vector3 begin = new Vector3 (-0.5f,-0.1f,0);
    private Vector3 end;
    private Vector3 difference;
    private float seconds = 0.4f;
    private bool close = true;
    public AudioSource source;
    public AudioClip DoorSlide;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("WhiteLight")){
            close = false;
            if (!source.isPlaying && (door.transform.position.x > -0.7f))
            {
                source.PlayOneShot(DoorSlide);
            }
            begin = door.transform.position;
            end = new Vector3 (-2f,0.6f,0);
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
            end = new Vector3 (-0.5f,-0.1f,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
    }
}
