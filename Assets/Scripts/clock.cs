using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clock : MonoBehaviour
{   
    //time is set to 1800 for 30 minutes
    public float timeValue = 1800;
    public Text timerText;
    public bool gameOver; 
    void Update()
    {
        //ads time based from the frame rate (incase game or computer framerate is diffrent)
        timeValue += Time.deltaTime; 
        
        //verify if time is above limit
        if(timeValue<3600)
        {
            DisplayTime(timeValue);
            
        }
        else
        {
        timerText.text = string.Format("00:00:00 AM");
        //change gameover to start losing game loop
        gameOver = true;
        }

    }
    void DisplayTime(float timeToDisplay)
    {
        //calculates seconds and minutes
        //float hours = Mathf.FloorToInt(timeToDisplay / 3600);
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        //will dissplay time 
        timerText.text = string.Format("11:{0:00}:{1:00} PM", minutes, seconds);



    }
}