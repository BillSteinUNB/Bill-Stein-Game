using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D c){
        if(c.gameObject.tag == "Player"){
            if(SceneManager.GetActiveScene().name == "Level 2"){
            SceneManager.LoadScene (sceneName:"Level 3");}
            else if (SceneManager.GetActiveScene().name == "Level 6"){
                SceneManager.LoadScene (sceneName:"Credits");
            }
            else if(SceneManager.GetActiveScene().name == "Level 4"){
                SceneManager.LoadScene (sceneName:"Level 5");
            }
            else if(SceneManager.GetActiveScene().name == "Level 5"){
                SceneManager.LoadScene (sceneName:"Level 6");
            }
            else{
               SceneManager.LoadScene (sceneName:"Level 4");
            }
        }
    }
}
