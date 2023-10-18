using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject Level1;

    void Start()
    {
        StartCoroutine(removeLevelDisplay());
    }

    IEnumerator removeLevelDisplay(){
    yield return new WaitForSecondsRealtime(3);
        Level1.SetActive(false);
    }

}
