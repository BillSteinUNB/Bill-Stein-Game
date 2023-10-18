using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxiDoorControllerL2 : MonoBehaviour
{
    public GameObject door;
    public GameObject player;
    private Vector3 begin = new Vector3 (17.1f,-8.5f,0);
    private Vector3 end;
    private Vector3 difference;
    private float seconds = 0.4f;
    public AudioSource source;
    public AudioClip DoorSlide;

    private void Update() {
        if (Vector3.Distance (door.transform.position, player.transform.position) < 3)
        {
            begin = door.transform.position;
            end = new Vector3 (17.8f,-8,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
        else{
            begin = door.transform.position;
            end = new Vector3 (17.1f,-8.5f,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
    }
}
