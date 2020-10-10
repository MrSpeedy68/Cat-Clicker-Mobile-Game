using Doozy.Engine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CatClick : MonoBehaviour
{
    // Start is called before the first frame update
    public double Score; //Main Score displayed ontop of the screen
    public int ScorePerClick; //The amount of score that will be added per click
    public int ScoreMultiplyer = 1; //The % amount the score will multiply by
    //private Button CatBtn;
    public TMP_Text MainScoreText; //Grab the Text from the button
    private Camera cam;
    SpooteDrops spooteDrops;
    AngerBar angerBar;
    ProgressBar progressBar;
    public int totalClicksPerSecond = 0; //Used to calculate the clicks per second
    public int currentClicksPerSecond = 0;


    public GameObject GameEventManager;
    private Button catButton;
    private UIButton catUIButton;

    public void Start()
    {
        //Load();
        cam = Camera.main;
        spooteDrops = GameEventManager.GetComponent<SpooteDrops>(); //Find The Main cat click script
        angerBar = GameEventManager.GetComponent<AngerBar>();
        progressBar = FindObjectOfType<ProgressBar>();

        catButton = gameObject.GetComponent<Button>();
        catUIButton = gameObject.GetComponent<UIButton>();

        //Wont be needed later
        TimerText.text = timer.ToString();
        MultiplyerText.text = "1X";
        //////////////
        
        InvokeRepeating("ClicksPerSecondCalculation", 0f, 1f); //Call the ClickPerSecondCalculation Method every second
        InvokeRepeating("Save", 0f, 5f); //Call the save method every 5 seconds
    }

    public int AmountTillNextSpooteCan = 20; //Amount of clicks till next Spoot Can drop


    public GameObject DroppingSnack;
    public float RotationSpeed = 50.0f;
    GameObject DropSnack;


    public void ClickOnCat()
    {
        Score += ScorePerClick * ScoreMultiplyer; //Add 1 to the score every time you click   
        currentClicksPerSecond++;
        //Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);

        //FloatingTextController.CreateFloatingText("+" + (ScorePerClick * ScoreMultiplyer).ToString(), mousePosition);

        angerBar.ReduceAngerBar();

        Vector3 SnackPoint = new Vector3();
        SnackPoint = cam.ScreenToWorldPoint(new Vector3(UnityEngine.Random.Range(cam.pixelWidth, 0f), cam.pixelHeight - 5f, cam.nearClipPlane + 1f));  //Make a new Vector2 at random coordinates above the screen
        DropSnack = Instantiate(DroppingSnack, SnackPoint, Quaternion.Euler(0.0f, 0.0f, UnityEngine.Random.Range(0.0f, 360.0f))); //Create a new Snack object at that Vector2 and random rotation.

        if (AmountTillNextSpooteCan == 0) //Handles drpping of the Milk
        {
            spooteDrops.DropSpooteCan();
        }
        else AmountTillNextSpooteCan--;
    }

    public void Update()
    {
        MainScoreText.text = ScoreFormatting(Score) + " Snacks!";
        
        MultiplierEvent(); //Runs Multiplyer event method

        if (startTimer) //Runs the timer for the multiplyer event
        {
            timer += Time.deltaTime;
            TimerText.text = timer.ToString();
        }
        else timer = 0;


        //Disables the button so the player cannot click anymore when the angerbar is at 0
        if (progressBar.current < 1)
        {
            catButton.enabled = false;
            catUIButton.enabled = false;
        }
        else
        {
            catButton.enabled = true;
            catUIButton.enabled = true;
        }

    }

    public string ScoreFormatting(double Score)
    {
        double numStr = 0d;
        string suffix = "";
        

        if(Score < 1000000d) //Format Under 1 Million
        {
            return Convert.ToDecimal(Score).ToString("#,##0"); //Set text to the current score value
        }
        else if(Score >= 1000000d && Score < 1000000000d) //Format Million
        {
            numStr = Score / 1000000d;
            suffix = "Million";
        }
        else if(Score >= 1000000000d && Score < 1000000000000f) //Format Billion
        {
            numStr = Score / 1000000000d;
            suffix = "Billion";
        }
        else if(Score >= 1000000000000d && Score < 1000000000000000d) //Format Trillion
        {
            numStr = Score / 1000000000000d;
            suffix = "Trillion";
        }
        else if(Score >= 1000000000000000d && Score < 1000000000000000000d) //Format Quadrillion
        {
            numStr = Score / 1000000000000000d;
            suffix = "Quadrillion";
        }
        else if(Score >= 1000000000000000000d && Score < 1000000000000000000000d) //Format Quintillion
        {
            numStr = Score / 1000000000000000000d;
            suffix = "Quintillion";
        }
        else if(Score >= 1000000000000000000000d && Score < 1000000000000000000000000d) //Format Sextillion
        {
            numStr = Score / 1000000000000000000000d;
            suffix = "Sextillion";
        }
        else if(Score >= 1000000000000000000000000d && Score < 1000000000000000000000000000d) //Format Septillion
        {
            numStr = Score / 1000000000000000000000000d;
            suffix = "Septillion";
        }
        else if(Score >= 1000000000000000000000000000d && Score < 1000000000000000000000000000000d) //Format Octillion
        {
            numStr = Score / 1000000000000000000000000000d;
            suffix = "Octillion";
        }
        else if(Score >= 1000000000000000000000000000000d && Score < 1000000000000000000000000000000000d) //Format Nonillion
        {
            numStr = Score / 1000000000000000000000000000000d;
            suffix = "Nonillion";
        }
        else if(Score >= 1000000000000000000000000000000000d) //Format Decillion
        {
            numStr = Score / 1000000000000000000000000000000000d;
            suffix = "Decillion";
        }

        return numStr.ToString("0.000") + " " + suffix;
    }

    public int ClicksPerSecondCalculation() //Handles cat clicks per second
    {
        totalClicksPerSecond = currentClicksPerSecond * ScoreMultiplyer;
        currentClicksPerSecond = 0;

        return totalClicksPerSecond;
    }

    public float timer; //The timer for multiplerEvent is set to start at 0 seconds
    private bool startTimer = false; //Boolean to tell the timer to start or stop
    public TMP_Text TimerText;
    public TMP_Text MultiplyerText;


    public void MultiplierEvent() //Handles Score multipler the more you click
    {
        if(totalClicksPerSecond < 5)
        {
            startTimer = false;
            ScoreMultiplyer = 1;
            MultiplyerText.text = ScoreMultiplyer + "x";
        }

        if (totalClicksPerSecond >= 5 && totalClicksPerSecond <= 8) //If clicking is between 5 and 8 per second multiplier is 2
        {
            startTimer = true; //Start the timer when clicks per second is between 5 and 8
            if(timer >= 10) //When the timer reaches 5 seconds add score multiplyer
            {
                ScoreMultiplyer = 2;
                MultiplyerText.text = ScoreMultiplyer + "X";
            }
        }
        /*else if(totalClicksPerSecond >= 9)//if clicking is 9 or more score multiplier is 3
        {
            ScoreMultiplyer = 3;
        }*/

    }

    public void Load()
    {
        //Load CatClick class variables like score
        Score = Double.Parse(PlayerPrefs.GetString("Score", "0.0"));
        ScorePerClick = PlayerPrefs.GetInt("ScorePerClick", 1);
    }

    public void Save()
    {
        //Save CatClick class variables like score
        PlayerPrefs.SetString("Score", Score.ToString());
        PlayerPrefs.SetInt("ScorePerClick", ScorePerClick);

    }
}
