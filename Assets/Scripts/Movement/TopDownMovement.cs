using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;
    public bool canMove = true;

    public AudioSource source;
    public AudioClip clip;
    int count = 0;

    public AudioClip backgroundMusicClip;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Add an AudioSource component to the game object
        audioSource = gameObject.AddComponent<AudioSource>();

        // Assign the background music clip to the AudioSource
        audioSource.clip = backgroundMusicClip;

        // Set the AudioSource properties
        audioSource.loop = true; // Loop the background music
        audioSource.volume = 0.5f; // Set the volume (0.0 to 1.0)

        // Play the background music
        audioSource.Play();
    }

    void Update()
    {
        if(canMove){
            if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") !=0 ){
            
                count++;
                if (count >= 200)
                {
                    //there are 3 different types of sounds for the 3 players
                    source.PlayOneShot(clip); //there are 4 different sounds to switch from
                    count = 0;
                }
            }
            moveInput.x = Input.GetAxisRaw("Horizontal");
            moveInput.y = Input.GetAxisRaw("Vertical");

            moveInput.Normalize();

            rb2d.velocity = moveInput * moveSpeed;

            

        }
    }

    // void OnTriggerEnter2D(Collider2D c){

    //     if(c.gameObject.tag == "Wall"){
    //         canMove = false;
    //         print("collider");
    //     } else{
    //         canMove = true;
    //     }
    // }
    // void OnTriggerExit2D(Collider2D c){
    // }
}
