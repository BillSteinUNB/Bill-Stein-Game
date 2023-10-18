using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float S1;
    public static float S2;
    public static float S3;
    public static float S4;
    public static float S5;
    public static float S6;
    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(timer);
    }

    // Update is called once per frame
    void Update()
    {   
        if(SceneManager.GetActiveScene().name == "Level 1"){
            S1 = Time.timeSinceLevelLoad;
        }
        else if(SceneManager.GetActiveScene().name == "Level 2"){
            S2 = Time.timeSinceLevelLoad;
           
        }
        else if(SceneManager.GetActiveScene().name == "Level 3"){
            S3 = Time.timeSinceLevelLoad;
          
        }
        else if(SceneManager.GetActiveScene().name == "Level 4"){
            S4 = Time.timeSinceLevelLoad;

        }
        else if(SceneManager.GetActiveScene().name == "Level 5"){
            S5 = Time.timeSinceLevelLoad;
        }
        else if(SceneManager.GetActiveScene().name == "Level 6"){
            S6 = Time.timeSinceLevelLoad;
        }
    }
}
