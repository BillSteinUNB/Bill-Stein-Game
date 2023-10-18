using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowSensorController : MonoBehaviour
{
    public GameObject door;
    private Vector3 begin = new Vector3 (0.95f,-0.8f,0);
    private Vector3 end;
    private Vector3 difference;
    private float seconds = 0.4f;
    private bool close = true;
    public AudioSource source;
    public AudioClip DoorSlide;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("YellowLight")){
             close = false;
            if (!source.isPlaying && (door.transform.position.x > 16))
            {
                source.PlayOneShot(DoorSlide);
            }
            begin = door.transform.position;
            end = new Vector3 (0.25f,-0.4f,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("YellowLight")){
            close = true;
        }
    }

    private void Update() {
        if(close == true){
            begin = door.transform.position;
            end = new Vector3 (0.95f, -0.8f, 0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
    }
}
