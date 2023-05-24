using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public void Timer()
    {

        timer.gameObject.SetActive(true);
        timerIsRunning = false;
        
    }
    
    public float timervalue = 5;
    public bool timerIsRunning = false;

    private void Start()
    {
        timerIsRunning = true;
     
    }
    // Update is called once per frame
    void Update()
    {
        timer.text = timervalue.ToString("N0");

        if (timerIsRunning)
        {
            if (timervalue >= 0)
            {
                timervalue -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Timer has run out");
               
                timervalue = 0;
                timerIsRunning = false;
            }


        }
    }
    
    }

