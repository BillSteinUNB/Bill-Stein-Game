using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Vector3 Spawn;
   
    //Light stuff
    public Vector3 P1Pos;
    public Vector3 P2Pos;
    public Vector3 P3Pos;
    public GameObject Flashlight;
    public GameObject LaserPointer;
    public GameObject Lamp;
    public GameObject LightBomb;
    public bool BombCD = true;
    //Sound stuff
    public AudioSource source;
    public AudioClip clip;
    //Player stuff
    public Animator anim;
    int playerSwapInt = 0;

    public int LevelInt;
    

    void Start()
    {
        Spawn = transform.position;
        
        LightBomb.SetActive(false);
        LaserPointer.SetActive(false);
        Lamp.SetActive(false);
        anim = GetComponent<Animator>();
        anim.Play("P1_Idle");

        P1Pos = transform.position;
        P2Pos = transform.position;
        P3Pos = transform.position;

        
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Level 1" || SceneManager.GetActiveScene().name == "Level 2"){
            LevelInt = 0;
        }
        else if(SceneManager.GetActiveScene().name == "Level 3" || SceneManager.GetActiveScene().name == "Level 4"){
            LevelInt = 1;
        }
        else if(SceneManager.GetActiveScene().name == "Level 5" || SceneManager.GetActiveScene().name == "Level 6"){
            LevelInt = 2;
        }
        if(Input.GetKeyDown("w") || Input.GetKeyDown("d") || Input.GetKeyDown("s") || Input.GetKeyDown("a")){
           switch(playerSwapInt){
            case 0:
            anim.Play("P1_Run");
            break;
            case 1:
            anim.Play("P2_Run");
            break;
            case 2:
            anim.Play("P3_Run");
            break;
            default:
            anim.Play("P1_Run");
            break;

        }
        }
        

        if(Input.GetKeyUp("w") || Input.GetKeyUp("d") || Input.GetKeyUp("s") || Input.GetKeyUp("a")){
            
            switch(playerSwapInt){
            case 0:
            anim.Play("P1_Idle");
            break;
            case 1:
            anim.Play("P2_Idle");
            break;
            case 2:
            anim.Play("P3_Idle");
            break;
            default:
            anim.Play("P1_Idle");
            break;

        }
        }
        if(LevelInt >0 ){
            if(Input.GetKeyDown(KeyCode.Space)){   

                PlayerSwap();
                switch(playerSwapInt){
                case 0:
                    LaserPointer.SetActive(false);
                    Lamp.SetActive(false);
                    Flashlight.SetActive(true);
                break;
                case 1:
                    Flashlight.SetActive(false);
                    LaserPointer.SetActive(true);

                break;
                case 2:
                    LaserPointer.SetActive(false);
                    Lamp.SetActive(true);

                break;
                default:
                Flashlight.SetActive(true);
                LaserPointer.SetActive(false);
                Lamp.SetActive(false);
                break;
                }

                source.PlayOneShot(clip); //play sound
            }

         }
         if(SceneManager.GetActiveScene().name != "Level 1"){   
         if(Input.GetKeyDown("m")){
                if(BombCD == true){
                LightBomb.SetActive(true);
                Debug.Log("Bomb Used!");
                BombCD = false;
                StartCoroutine(BombTimer());
                }
                else{
                    Debug.Log("Bomb is still on CD");
                }
            }}  
      }

    void PlayerSwap(){
        if(playerSwapInt <LevelInt){
            playerSwapInt++;
        }
        else{
            playerSwapInt =0 ;
        }

        switch(playerSwapInt){
            case 0:
            P1Pos = transform.position;
            transform.position = P2Pos;
            anim.Play("P1_Idle");
            break;
            case 1:
            if(LevelInt == 2){ 
            P2Pos = transform.position;
            transform.position = P3Pos;
            }
            else{
                P2Pos = transform.position;
                transform.position = P1Pos;
            }
            anim.Play("P2_Idle");
            break;
            case 2:
            P3Pos = transform.position;
            transform.position = P1Pos;
            anim.Play("P3_Idle");
            break;
            default:
            anim.Play("P1_Idle");
            break;

        }


    }



    IEnumerator BombTimer()
    {
        yield return new WaitForSecondsRealtime(2);
        LightBomb.SetActive(false);
        Debug.Log("Bomb Cleared!");
        yield return new WaitForSecondsRealtime(13);
        Debug.Log("Bomb Ready!");
        BombCD = true;
    }
}



