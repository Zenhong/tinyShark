using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float GameTimeInSeconds;
    float currentTime;
    bool gameRunning = true;
    public Slider m_TimerSlider;

    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameRunning) 
        {
            currentTime += Time.deltaTime;
            if (currentTime >= GameTimeInSeconds)
            {
                // Game Complete
                
            }
            m_TimerSlider.value = currentTime / GameTimeInSeconds;
        }
        
    }

    void GameComplete() 
    {
        gameRunning = false;
    }
}
