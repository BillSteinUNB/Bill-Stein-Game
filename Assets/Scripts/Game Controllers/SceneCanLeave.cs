using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneCanLeave : MonoBehaviour
{
    bool canleave = false;
    public GameObject CheckPlate1;
    public GameObject CheckPlate2;
    public GameObject CheckPlate3;
    public GameObject CheckPlate4;
    public GameObject CheckPlate5;
    public GameObject CheckPlate6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!CheckPlate1.activeSelf && !CheckPlate2.activeSelf && !CheckPlate3.activeSelf && !CheckPlate4.activeSelf && !CheckPlate5.activeSelf && !CheckPlate6.activeSelf){
            canleave = true;
        }

        if(transform.position.x >= 4.3f && transform.position.x <=5.3f && transform.position.y >= 5.6){
            if(canleave == true){
                SceneManager.LoadScene (sceneName:"Level 2");
            }
        }
    }
}
