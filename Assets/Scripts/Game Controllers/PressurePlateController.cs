using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PressurePlateController : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    public GameObject Player;
    int x = 0;
    public bool NoNoZone = true;
    
    
    public static bool openDoor = false; //If level 1 is complete (then door will open)

    void Start()
    {
        
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //p1 >=x4.7 <= 5.5 y0 1
        //=2 x  11.8 12.8 y 4.2 4.8
        //p3 x 6 6.8 y 3.5 4.0
        //p4 x 0.6, 1.6 y 1.6 2.3
        //p5 14 15 y -.5 .1
        // p6 5.7 6.7 y 5.8 6.5
       //This is about to be the most cursed code fix yall have ever seen in ur careers

    //P1

    if(p1.activeSelf){
        
        if(Player.transform.position.x >= 4.7f && Player.transform.position.x <= 5.5f && Player.transform.position.y >= 0f && Player.transform.position.y <= 1f){
            NoNoZone = false;
        }
        else{
            NoNoZone = true;
        }
    }
    else if(p2.activeSelf){
        if(Player.transform.position.x >= 11.8f && Player.transform.position.x <= 12.8f && Player.transform.position.y >= 4.2f && Player.transform.position.y <= 4.8f){
            NoNoZone = false;
        }
        else{
            NoNoZone = true;
        }
    }
    else if(p3.activeSelf){
        if(Player.transform.position.x >= 6f && Player.transform.position.x <= 7f && Player.transform.position.y >= 3.5f && Player.transform.position.y <= 4f){
            NoNoZone = false;
        }
        else{
            NoNoZone = true;
        }
    }
    else if(p4.activeSelf){
        if(Player.transform.position.x >= 0.6f && Player.transform.position.x <= 1.6f && Player.transform.position.y >= 1.6f && Player.transform.position.y <= 2.3f){
            NoNoZone = false;
        }
        else{
            NoNoZone = true;
        }
    }
    else if(p5.activeSelf){
        if(Player.transform.position.x >= 13.5f && Player.transform.position.x <= 15f && Player.transform.position.y >= -0.6f && Player.transform.position.y <= 0.2f){
            NoNoZone = false;
        }
        else{
            NoNoZone = true;
        }
    }
    else if(p6.activeSelf){
        if(Player.transform.position.x >= 5.7f && Player.transform.position.x <= 6.7f && Player.transform.position.y >= 5.8f && Player.transform.position.y <= 6.5f){
            NoNoZone = false;
        }
        else{
            NoNoZone = true;
        }
    }

    }
    void OnTriggerEnter2D(Collider2D c){
        if(NoNoZone == false){   
            if (c.gameObject.tag == "Player"){
                x++;
                switch(x){
                    case 1:
                        p1.SetActive(false);
                        p2.SetActive(true);
                    break;
                    case 2:
                        p2.SetActive(false);
                        p3.SetActive(true);
                    break;
                    case 3:
                        p3.SetActive(false);
                        p4.SetActive(true);
                    break;
                    case 4:
                        p4.SetActive(false);
                        p5.SetActive(true);
                    break;
                    case 5:
                        p5.SetActive(false);
                        p6.SetActive(true);
                    break;
                    case 6:
                        p6.SetActive(false);
                        openDoor = true; //All pressure plates are pressed open door
                        print("open door");
                    break;
                    case 7:
                        Debug.Log(x);
                       
                    break;
                    default:
                        p1.SetActive(true);
                        p2.SetActive(false);
                        p3.SetActive(false);
                        p4.SetActive(false);
                        p5.SetActive(false);
                        p6.SetActive(false);
                    break;
                }
                }
            }     
        }   
        void OnTriggerStay2D(Collider2D c){
        if(NoNoZone == false){   
            if (c.gameObject.tag == "Player"){
                x++;
                switch(x){
                    case 1:
                        p1.SetActive(false);
                        p2.SetActive(true);
                    break;
                    case 2:
                        p2.SetActive(false);
                        p3.SetActive(true);
                    break;
                    case 3:
                        p3.SetActive(false);
                        p4.SetActive(true);
                    break;
                    case 4:
                        p4.SetActive(false);
                        p5.SetActive(true);
                    break;
                    case 5:
                        p5.SetActive(false);
                        p6.SetActive(true);
                    break;
                    case 6:
                        p6.SetActive(false);
                        openDoor = true; //All pressure plates are pressed open door
                        print("open door");
                    break;
                    case 7:
                        Debug.Log(x);
                       
                    break;
                    default:
                        p1.SetActive(true);
                        p2.SetActive(false);
                        p3.SetActive(false);
                        p4.SetActive(false);
                        p5.SetActive(false);
                        p6.SetActive(false);
                    break;
                }
                }
            }     
        }     
}
