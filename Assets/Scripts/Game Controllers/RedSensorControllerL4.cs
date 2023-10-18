using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSensorControllerL4 : MonoBehaviour
{
    public GameObject door;
    private Vector3 begin = new Vector3 (15.7f,-7,0);
    private Vector3 end;
    private Vector3 difference;
    private float seconds = 0.4f;
    private bool close = true;
    public AudioSource source;
    public AudioClip DoorSlide;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("RedLight")){
             close = false;
            if (!source.isPlaying && (door.transform.position.x < 15.4f))
            {
                source.PlayOneShot(DoorSlide);
            }
            begin = door.transform.position;
            end = new Vector3 (14.7f,-6.4f,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("RedLight")){
            close = true;
        }
    }

    private void Update() {
        if(close == true){
            begin = door.transform.position;
            end = new Vector3 (15.7f,-7,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
    }
}
