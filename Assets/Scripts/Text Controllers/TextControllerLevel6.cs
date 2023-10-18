using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControllerLevel6 : MonoBehaviour
{
    public GameObject Lvl6;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ByeText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ByeText(){
        yield return new WaitForSecondsRealtime(7);
        Lvl6.SetActive(false);
    }
}