using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorController : MonoBehaviour
{
    public GameObject door;
    private Vector3 begin = new Vector3 (4.4f,6.75f, 0);
    private Vector3 end;
    private Vector3 difference;
    private float seconds = 0.4f;
    public AudioSource source;
    public AudioClip DoorSlide;
    bool playedOnce = false;

    private void Update() {
        if(PressurePlateController.openDoor == true){
            if (!source.isPlaying && playedOnce == false)
            {
                source.PlayOneShot(DoorSlide);
                playedOnce = true;
            }
            if(door.transform.position.x < 5.4f){
                begin = door.transform.position;
                end = new Vector3 (5.5f,7.4f,0);
                difference = end - begin;
                door.transform.position += difference * Time.deltaTime * seconds;
            }
            
        }
    }
}
