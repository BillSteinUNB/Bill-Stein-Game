using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour
{
    public TextMeshProUGUI Credits;
    // public TextMeshProUGUI creditText;
    public RectTransform myRect;
    float y = -761;

    public int S1;
    public int S2;
    public int S3;
    public int S4;
    public int S5;
    public int S6;

    // Update is called once per frame
    void Start(){
        S1 = (int)Timer.S1;
        S2 = (int)Timer.S2;
        S3 = (int)Timer.S3;
        S4 = (int)Timer.S4;
        S5 = (int)Timer.S5;
        S6 = (int)Timer.S6;
        int total = S1+S2+S3+S4+S5+S6;
        Credits.text = "YOU WIN!\n" + "Your Splits Are:\nLevel 1: " + S1 + "s" + 
"\nLevel 2: " + S2 + "s" + 
"\nLevel 3: " + S3+ "s" + 
"\nLevel 4: " + S4+ "s" + 
"\nLevel 5: " + S5+ "s" + 
"\nLevel 6: " + S6+ "s" + 

"\nTotal: " + total + "s" + 

"\nThank you so much for playing our game!\n\n" + 

"Designers:\nBill Stein\nNicolas Bisaillon\nSimon Bisaillon"+

"\n\nCourse: CS 2053" + "\nTeacher:\nIan Smith"+

"\n\nFont\nhttps://www.1001freefonts.com/the-unknown.font"+

"\n\nBackgroud assets\nhttps://www.reddit.com/r/PixelArt/comments/7wdjye/occc_parallax_background_for_my_dungeon/"+

"\n\nSounds\n\nTileSet";
    }
    void FixedUpdate()
    {
        y = y + 1.5f;
        myRect.transform.localPosition = new Vector3(0, y, 0);
        if(y > 1400 ){
            SceneManager.LoadScene("Menu");
        }
        
    }

     public void BackToMenu(){
        SceneManager.LoadScene("Menu");
    }
}
