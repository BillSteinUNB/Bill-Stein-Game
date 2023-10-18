using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5EndDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject player;
    private Vector3 begin = new Vector3 (24.6f,-19.7f,0);
    private Vector3 end;
    private Vector3 difference;
    private float seconds = 0.4f;
    public AudioSource source;
    public AudioClip DoorSlide;

    private void Update() {
        if (Vector3.Distance (door.transform.position, player.transform.position) < 2)
        {
            begin = door.transform.position;
            end = new Vector3 (25.3f,-19.3f,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
        else{
            begin = door.transform.position;
            end = new Vector3 (24.6f,-19.7f,0);
            difference = end - begin;
            door.transform.position += difference * Time.deltaTime * seconds;
        }
    }
}

