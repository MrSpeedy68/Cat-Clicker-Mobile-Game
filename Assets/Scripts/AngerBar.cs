using Doozy.Engine.UI;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngerBar : MonoBehaviour
{
    public GameObject angerProgressBar;
    CatClick catClick;
    ProgressBar progressBar;

    

    // Start is called before the first frame update
    void Start()
    {
        progressBar = angerProgressBar.GetComponent<ProgressBar>();

        catClick = FindObjectOfType<CatClick>();
    }

    //public bool zeroAnger = false;
    public void ReduceAngerBar()
    {
        //Every time you click the current value in the bar is decreased by an amount
        //if the bar is less than the decrease amount then dont decreease
        if (progressBar.current >= 1 && progressBar.current != 0)
        {
            progressBar.current--;
        }
        if (progressBar.current < 0.99 && progressBar.current != 0) //Because the bar is a float, need to eliminate that last remaining value below 1
        {
            progressBar.current = 0;
        }
    }

    public float targetTime = 5.0f; //The amount of time since last click till the par regens
    private bool timerStart = false; //Boolean to start or stop timer
    public int increaseOverTimeAmount = 5; //How much over time the bar will increase

    // Update is called once per frame
    void Update()
    {

        if (catClick.currentClicksPerSecond == 0)
        {
            timerStart = true;
        }
        else timerStart = false;

        //Runs down timer after last click and then runs the increase bar method
        if (timerStart)
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f && progressBar.current < progressBar.maximum)
            {
                progressBar.current += increaseOverTimeAmount * Time.deltaTime;     
            }
        }
        else targetTime = 1.0f;
    }


}
