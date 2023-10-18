using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControllerLevel2 : MonoBehaviour
{
    public GameObject Lvl2;
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
        yield return new WaitForSecondsRealtime(5);
        Lvl2.SetActive(false);
    }
}