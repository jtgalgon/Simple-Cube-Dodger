using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScores : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject livesText;
    private GameObject touchDownText;
    private int lives = 10;
    private int touchDowns = 0;
    void Start()
    {
        livesText = GameObject.Find("Lives");
        touchDownText = GameObject.Find("TouchDowns");
    }

    public void updateLives(){
        if(lives == 0){
            Application.Quit();
            Debug.Log("Application has quit");
        }else{
            lives--;
            livesText.GetComponent<UnityEngine.UI.Text>().text = "Lives - " + lives.ToString();
        }
    }

    public void updateTouchDowns(){
        touchDowns++;
        touchDownText.GetComponent<UnityEngine.UI.Text>().text = "Touch Downs - " + touchDowns.ToString();
    }
}
