using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControllerLvl1 : MonoBehaviour
{
    public GameObject Lvl1;
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
        Lvl1.SetActive(false);
    }
}
