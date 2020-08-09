using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    CatClick catClick;
    private float GlobalMultiplyer = 1.17f;
    public GameObject CatButton;


    public void Load()
    {
        //Load Kitten Upgrade
        KittenLevel = PlayerPrefs.GetInt("KittenLevel", 0);
        KittenProduction = PlayerPrefs.GetFloat("KittenProduction", 0f);
        KittenPrice = PlayerPrefs.GetFloat("KittenPrice", 20f);
        KittenProdIncrease = PlayerPrefs.GetFloat("KittenProdIncrease", 0.1f);

        //Load Chonker Upgrade
        ChonkerLevel = PlayerPrefs.GetInt("ChonkerLevel", 0);
        ChonkerProduction = PlayerPrefs.GetFloat("ChonkerProduction", 0f);
        ChonkerPrice = PlayerPrefs.GetFloat("ChonkerPrice", 100f);
        ChonkerProdIncrease = PlayerPrefs.GetFloat("ChonkerProdIncrease", 1f);

        //Load Bee Cat Upgrade
        BeeCatLevel = PlayerPrefs.GetInt("BeeCatLevel", 0);
        BeeCatProduction = PlayerPrefs.GetFloat("BeeCatProduction", 0f);
        BeeCatPrice = PlayerPrefs.GetFloat("BeeCatPrice", 1000f);
        BeeCatProdIncrease = PlayerPrefs.GetFloat("BeeCatProdIncrease", 9f);

        //Load Lasagne Boy Upgrade
        LasagneBoyLevel = PlayerPrefs.GetInt("LasagneBoyLevel", 0);
        LasagneBoyProduction = PlayerPrefs.GetFloat("LasagneBoyProduction", 0f);
        LasagneBoyPrice = PlayerPrefs.GetFloat("LasagneBoyPrice", 12500f);
        LasagneBoyProdIncrease = PlayerPrefs.GetFloat("LasagneBoyProdIncrease", 50f);

        //Load Pirate Cat Upgrade
        PirateBoyLevel = PlayerPrefs.GetInt("PirateBoyLevel", 0);
        PirateBoyProduction = PlayerPrefs.GetFloat("PirateBoyProduction", 0f);
        PirateBoyPrice = PlayerPrefs.GetFloat("PirateBoyPrice", 125000f);
        PirateBoyProdIncrease = PlayerPrefs.GetFloat("PirateBoyProdIncrease", 250f);

        //Load Spy Cat Upgrade
        SpyCatLevel = PlayerPrefs.GetInt("SpyCatLevel", 0);
        SpyCatProduction = PlayerPrefs.GetFloat("SpyCatProduction", 0f);
        SpyCatPrice = PlayerPrefs.GetFloat("SpyCatPrice", 1500000f);
        SpyCatProdIncrease = PlayerPrefs.GetFloat("SpyCatProdIncrease", 1300f);

        //Load Inbread Cat Upgrade
        InbreadCatLevel = PlayerPrefs.GetInt("InbreadCatLevel", 0);
        InbreadCatProduction = PlayerPrefs.GetFloat("InbreadCatProduction", 0f);
        InbreadCatPrice = PlayerPrefs.GetFloat("InbreadCatPrice", 20000000f);
        InbreadCatProdIncrease = PlayerPrefs.GetFloat("InbreadCatProdIncrease", 7500f);

        //Load Void Cat Upgrade
        VoidCatLevel = PlayerPrefs.GetInt("VoidCatLevel", 0);
        VoidCatProduction = PlayerPrefs.GetFloat("VoidCatProduction", 0f);
        VoidCatPrice = PlayerPrefs.GetFloat("VoidCatPrice", 320000000f);
        VoidCatProdIncrease = PlayerPrefs.GetFloat("VoidCatProdIncrease", 45000f);
    }

    public void Save()
    {
        //Save Kitten Upgrade
        PlayerPrefs.SetInt("KittenLevel", KittenLevel);
        PlayerPrefs.SetFloat("KittenProduction", KittenProduction);
        PlayerPrefs.SetFloat("KittenPrice", KittenPrice);
        PlayerPrefs.SetFloat("KittenProdIncrease", KittenProdIncrease);

        //Save Chonker Upgrade
        PlayerPrefs.SetInt("ChonkerLevel", ChonkerLevel);
        PlayerPrefs.SetFloat("ChonkerProduction", ChonkerProduction);
        PlayerPrefs.SetFloat("ChonkerPrice", ChonkerPrice);
        PlayerPrefs.SetFloat("ChonkerProdIncrease", ChonkerProdIncrease);

        //Save Bee Cat Upgrade
        PlayerPrefs.SetInt("BeeCatLevel", BeeCatLevel);
        PlayerPrefs.SetFloat("BeeCatProduction", BeeCatProduction);
        PlayerPrefs.SetFloat("BeeCatPrice", BeeCatPrice);
        PlayerPrefs.SetFloat("BeeCatProdIncrease", BeeCatProdIncrease);

        //Save Lasagne Boy Upgrade
        PlayerPrefs.SetInt("LasagneBoyLevel", LasagneBoyLevel);
        PlayerPrefs.SetFloat("LasagneBoyProduction", LasagneBoyProduction);
        PlayerPrefs.SetFloat("LasagneBoyPrice", LasagneBoyPrice);
        PlayerPrefs.SetFloat("LasagneBoyProdIncrease", LasagneBoyProdIncrease);

        //Save Pirate Cat Upgrade
        PlayerPrefs.SetInt("PirateBoyLevel", PirateBoyLevel);
        PlayerPrefs.SetFloat("PirateBoyProduction", PirateBoyProduction);
        PlayerPrefs.SetFloat("PirateBoyPrice", PirateBoyPrice);
        PlayerPrefs.SetFloat("PirateBoyProdIncrease", PirateBoyProdIncrease);

        //Save Spy Cat Upgrade
        PlayerPrefs.SetInt("SpyCatLevel", SpyCatLevel);
        PlayerPrefs.SetFloat("SpyCatProduction", SpyCatProduction);
        PlayerPrefs.SetFloat("SpyCatPrice", SpyCatPrice);
        PlayerPrefs.SetFloat("SpyCatProdIncrease", SpyCatProdIncrease);

        //Save Inbread Cat Upgrade
        PlayerPrefs.SetInt("InbreadCatLevel", InbreadCatLevel);
        PlayerPrefs.SetFloat("InbreadCatProduction", InbreadCatProduction);
        PlayerPrefs.SetFloat("InbreadCatPrice", InbreadCatPrice);
        PlayerPrefs.SetFloat("InbreadCatProdIncrease", InbreadCatProdIncrease);

        //Save Void Cat Upgrade
        PlayerPrefs.SetInt("VoidCatLevel", VoidCatLevel);
        PlayerPrefs.SetFloat("VoidCatProduction", VoidCatProduction);
        PlayerPrefs.SetFloat("VoidCatPrice", VoidCatPrice);
        PlayerPrefs.SetFloat("VoidCatProdIncrease", VoidCatProdIncrease);

    }


    // Start is called before the first frame update
    void Start()
    {
        //Load();

        FloatingTextController.Initialize();

        catClick = CatButton.GetComponent<CatClick>(); //Find The Main cat click script

        ChonkerPriceText.text = "" + UpgradesFormatting(ChonkerPrice); //Initialize PriceTag
        ChonkerLevelText.text = "" + ChonkerLevel; //Initialize LevelTag

        KittenPriceText.text = "" + UpgradesFormatting(KittenPrice);
        KittenLevelText.text = "" + KittenLevel;

        BeeCatPriceText.text = "" + UpgradesFormatting(BeeCatPrice);
        BeeCatLevelText.text = "" + BeeCatLevel;

        LasagneBoyPriceText.text = "" + UpgradesFormatting(LasagneBoyPrice);
        LasagneBoyLevelText.text = "" + LasagneBoyLevel;

        PirateBoyPriceText.text = "" + UpgradesFormatting(PirateBoyPrice);
        PirateBoyLevelText.text = "" + PirateBoyLevel;

        SpyCatPriceText.text = "" + UpgradesFormatting(SpyCatPrice);
        SpyCatLevelText.text = "" + SpyCatLevel;

        InbreadCatPriceText.text = "" + UpgradesFormatting(InbreadCatPrice);
        InbreadCatLevelText.text = "" + InbreadCatLevel;

        VoidCatPriceText.text = "" + UpgradesFormatting(VoidCatPrice);
        VoidCatLevelText.text = "" + VoidCatLevel;

        InvokeRepeating("ProductionPerSecond", 0f, 1.0f); //Run the production every second.
        InvokeRepeating("Save", 0f, 5f); //Call the Save method every 5 seconds

        HandlePurchaseMultiple();
    }

    //---------------Shop Menu---------------


    //Kitten Upgrade
    private int KittenLevel;
    private float KittenProduction;
    public float KittenPrice;
    public float KittenProdIncrease;
    public int KittenMultiplyer;
    public TMP_Text KittenPriceText;
    public TMP_Text KittenLevelText;

    public void KittenButton()
    {
        if (catClick.Score != 0 && catClick.Score >= KittenPrice) //Check if the score is higher or equal to the price
        {
            catClick.Score = catClick.Score - KittenPrice; // Removes the amount of score it cost to purchase

            KittenLevel++; //Add 1 to the level amount
            KittenProduction = (KittenProdIncrease * KittenLevel) * KittenMultiplyer; //Increase the production of the upgrade if there is a multiplyer add it too
            KittenPrice = Mathf.Ceil(20 * Mathf.Pow(GlobalMultiplyer, KittenLevel)); //Increase price by the global multiplier value to the power of the level of the upgrade
            //KittenPrice = 20 * (Mathf.Pow(GlobalMultiplyer, 1) * (Mathf.Pow(GlobalMultiplyer, 10) - 1)) / GlobalMultiplyer - 1;

            KittenPriceText.text = "" + UpgradesFormatting(KittenPrice);
            KittenLevelText.text = "" + KittenLevel;

            Debug.Log("Level is: " + KittenLevel);
            Debug.Log("Price is: " + KittenPrice);
            Debug.Log("Production is: " + KittenProduction);

        }
        else Debug.Log("You're Poor!");
    }


    //Chonker Upgrade
    private int ChonkerLevel; //What Level it current is
    private float ChonkerProduction; //How much score it produces per second
    public float ChonkerPrice; //Its current price
    public float ChonkerProdIncrease; //The amount of production increase per level
    public int ChonkerMultiplayer;
    public TMP_Text ChonkerPriceText;
    public TMP_Text ChonkerLevelText;

    public void ChonkerButton()
    {
       
        if (catClick.Score != 0 && catClick.Score >= ChonkerPrice) //Check if the score is higher or equal to the price
        {
            catClick.Score = catClick.Score - ChonkerPrice; // Removes the amount of score it cost to purchase

            ChonkerLevel++; //Add 1 to the level amount
            ChonkerProduction = (ChonkerProdIncrease * ChonkerLevel) * ChonkerMultiplayer; //Increase the production of the upgrade
            ChonkerPrice = Mathf.Ceil(100 * Mathf.Pow(GlobalMultiplyer,ChonkerLevel)); //Increase price by the global multiplier value

            ChonkerPriceText.text = "" + UpgradesFormatting(ChonkerPrice);
            ChonkerLevelText.text = "" + ChonkerLevel;

            Debug.Log("Level is: " + ChonkerLevel);
            Debug.Log("Price is: " + ChonkerPrice);
            Debug.Log("Production is: " + ChonkerProduction);

        }
        else Debug.Log("You're Poor!");
    }



    //Bee Cat Upgrade
    private int BeeCatLevel;
    private float BeeCatProduction;
    public float BeeCatPrice;
    public float BeeCatProdIncrease;
    public int BeeCatMultiplayer;
    public TMP_Text BeeCatPriceText;
    public TMP_Text BeeCatLevelText;

    public void BeeCatButton()
    {
        if (catClick.Score != 0 && catClick.Score >= BeeCatPrice) //Check if the score is higher or equal to the price
        {
            catClick.Score = catClick.Score - BeeCatPrice; // Removes the amount of score it cost to purchase

            BeeCatLevel++; //Add 1 to the level amount
            BeeCatProduction = (BeeCatProdIncrease * BeeCatLevel) * BeeCatMultiplayer; //Increase the production of the upgrade
            BeeCatPrice = Mathf.Ceil(1000 * Mathf.Pow(GlobalMultiplyer,BeeCatLevel)); //Increase price by the global multiplier value

            BeeCatPriceText.text = "" + UpgradesFormatting(BeeCatPrice);
            BeeCatLevelText.text = "" + BeeCatLevel;

            Debug.Log("Level is: " + BeeCatLevel);
            Debug.Log("Price is: " + BeeCatPrice);
            Debug.Log("Production is: " + BeeCatProduction);

        }
        else Debug.Log("You're Poor!");
    }


    //Lasagne Boy Upgrade
    private int LasagneBoyLevel;
    private float LasagneBoyProduction;
    public float LasagneBoyPrice;
    public float LasagneBoyProdIncrease;
    public int LasagneBoyMultiplayer;
    public TMP_Text LasagneBoyPriceText;
    public TMP_Text LasagneBoyLevelText;

    public void LasagneBoyButton()
    {
        if (catClick.Score != 0 && catClick.Score >= LasagneBoyPrice) //Check if the score is higher or equal to the price
        {
            catClick.Score = catClick.Score - LasagneBoyPrice; // Removes the amount of score it cost to purchase

            LasagneBoyLevel++; //Add 1 to the level amount
            LasagneBoyProduction = (LasagneBoyProdIncrease * LasagneBoyLevel) * LasagneBoyMultiplayer; //Increase the production of the upgrade
            LasagneBoyPrice = Mathf.Ceil(12500 * Mathf.Pow(GlobalMultiplyer,LasagneBoyLevel)); //Increase price by the global multiplier value

            LasagneBoyPriceText.text = "" + UpgradesFormatting(LasagneBoyPrice);
            LasagneBoyLevelText.text = "" + LasagneBoyLevel;

            Debug.Log("Level is: " + LasagneBoyLevel);
            Debug.Log("Price is: " + LasagneBoyPrice);
            Debug.Log("Production is: " + LasagneBoyProduction);

        }
        else Debug.Log("You're Poor!");
    }

    
    //Pirate Cat Upgrade
    private int PirateBoyLevel;
    private float PirateBoyProduction;
    public float PirateBoyPrice;
    public float PirateBoyProdIncrease;
    public int PirateBoyMultiplayer;
    public TMP_Text PirateBoyPriceText;
    public TMP_Text PirateBoyLevelText;

    public void PirateCatButton()
    {
        if (catClick.Score != 0 && catClick.Score >= PirateBoyPrice) //Check if the score is higher or equal to the price
        {
            catClick.Score = catClick.Score - PirateBoyPrice; // Removes the amount of score it cost to purchase

            PirateBoyLevel++; //Add 1 to the level amount
            PirateBoyProduction = (PirateBoyProdIncrease * PirateBoyLevel) * PirateBoyMultiplayer; //Increase the production of the upgrade
            PirateBoyPrice = Mathf.Ceil(125000 * Mathf.Pow(GlobalMultiplyer,LasagneBoyLevel)); //Increase price by the global multiplier value

            PirateBoyPriceText.text = "" + UpgradesFormatting(PirateBoyPrice);
            PirateBoyLevelText.text = "" + PirateBoyLevel;

            Debug.Log("Level is: " + PirateBoyLevel);
            Debug.Log("Price is: " + PirateBoyPrice);
            Debug.Log("Production is: " + PirateBoyProduction);

        }
        else Debug.Log("You're Poor!");
    } 

    
    //Spy Cat Upgrade
    private int SpyCatLevel;
    private float SpyCatProduction;
    public float SpyCatPrice;
    public float SpyCatProdIncrease;
    public int SpyCatMultiplayer;
    public TMP_Text SpyCatPriceText;
    public TMP_Text SpyCatLevelText;

    public void SpyCatButton()
    {
        if (catClick.Score != 0 && catClick.Score >= SpyCatPrice) //Check if the score is higher or equal to the price
        {
            catClick.Score = catClick.Score - SpyCatPrice; // Removes the amount of score it cost to purchase

            SpyCatLevel++; //Add 1 to the level amount
            SpyCatProduction = (SpyCatProdIncrease * SpyCatLevel) * SpyCatMultiplayer; //Increase the production of the upgrade
            SpyCatPrice = Mathf.Ceil(1500000 * Mathf.Pow(GlobalMultiplyer,SpyCatLevel)); //Increase price by the global multiplier value

            SpyCatPriceText.text = "" + UpgradesFormatting(SpyCatPrice);
            SpyCatLevelText.text = "" + SpyCatLevel;

            Debug.Log("Level is: " + SpyCatLevel);
            Debug.Log("Price is: " + SpyCatPrice);
            Debug.Log("Production is: " + SpyCatProduction);

        }
        else Debug.Log("You're Poor!");
    }


    //Inbread Cat Upgrade
    private int InbreadCatLevel;
    private float InbreadCatProduction;
    public float InbreadCatPrice;
    public float InbreadCatProdIncrease;
    public int InbreadCatMultiplayer;
    public TMP_Text InbreadCatPriceText;
    public TMP_Text InbreadCatLevelText;

    public void InbreadCatButton()
    {
        if (catClick.Score != 0 && catClick.Score >= InbreadCatPrice) //Check if the score is higher or equal to the price
        {
            catClick.Score = catClick.Score - InbreadCatPrice; // Removes the amount of score it cost to purchase

            InbreadCatLevel++; //Add 1 to the level amount
            InbreadCatProduction = (InbreadCatProdIncrease * InbreadCatLevel) * InbreadCatMultiplayer; //Increase the production of the upgrade
            InbreadCatPrice = Mathf.Ceil(20000000 * Mathf.Pow(GlobalMultiplyer,InbreadCatLevel)); //Increase price by the global multiplier value

            InbreadCatPriceText.text = "" + UpgradesFormatting(InbreadCatPrice);
            InbreadCatLevelText.text = "" + InbreadCatLevel;

            Debug.Log("Level is: " + InbreadCatLevel);
            Debug.Log("Price is: " + InbreadCatPrice);
            Debug.Log("Production is: " + InbreadCatProduction);

        }
        else Debug.Log("You're Poor!");
    }

    //Void Cat Upgrade
    private int VoidCatLevel;
    private float VoidCatProduction;
    public float VoidCatPrice;
    public float VoidCatProdIncrease;
    public int VoidCatMultiplayer;
    public TMP_Text VoidCatPriceText;
    public TMP_Text VoidCatLevelText;

    public void VoidCatButton()
    {
        if (catClick.Score != 0 && catClick.Score >= VoidCatPrice) //Check if the score is higher or equal to the price
        {
            catClick.Score = catClick.Score - VoidCatPrice; // Removes the amount of score it cost to purchase

            VoidCatLevel++; //Add 1 to the level amount
            VoidCatProduction = (VoidCatProdIncrease * VoidCatLevel) * VoidCatMultiplayer; //Increase the production of the upgrade
            VoidCatPrice = Mathf.Ceil(320000000 * Mathf.Pow(GlobalMultiplyer,VoidCatLevel)); //Increase price by the global multiplier value

            VoidCatPriceText.text = UpgradesFormatting(VoidCatPrice);
            VoidCatLevelText.text = "" + VoidCatLevel;

            Debug.Log("Level is: " + VoidCatLevel);
            Debug.Log("Price is: " + VoidCatPrice);
            Debug.Log("Production is: " + VoidCatProduction);

        }
        else Debug.Log("You're Poor!");
    }




    public TMP_Text ScorePerSecond;
    //Calculates the total production per second.
    public double ProductionPerSecond()
    {
        float TotalProduction = KittenProduction + ChonkerProduction + BeeCatProduction + LasagneBoyProduction + PirateBoyProduction + SpyCatProduction + InbreadCatProduction + VoidCatProduction;
        catClick.Score += TotalProduction;
        ScorePerSecond.text = Convert.ToDecimal(catClick.totalClicksPerSecond + TotalProduction).ToString("#,##0.00") + " Snacks Per Second";

        return catClick.Score;
    }

    public string UpgradesFormatting(float Score)
    {
        float numStr = 0f;
        string suffix = "";


        if (Score < 1000000f) //Format Under 1 Million
        {
            return Convert.ToDecimal(Score).ToString("#,##0"); //Set text to the current score value
        }
        else if (Score >= 1000000f && Score < 1000000000f) //Format Million
        {
            numStr = Score / 1000000f;
            suffix = "M";
        }
        else if (Score >= 1000000000f && Score < 1000000000000f) //Format Billion
        {
            numStr = Score / 1000000000f;
            suffix = "B";
        }
        else if (Score >= 1000000000000f && Score < 1000000000000000f) //Format Trillion
        {
            numStr = Score / 1000000000000f;
            suffix = "T";
        }
        else if (Score >= 1000000000000000f && Score < 1000000000000000000f) //Format Quadrillion
        {
            numStr = Score / 1000000000000000f;
            suffix = "q";
        }
        else if (Score >= 1000000000000000000f && Score < 1000000000000000000000f) //Format Quintillion
        {
            numStr = Score / 1000000000000000000f;
            suffix = "Q";
        }
        else if (Score >= 1000000000000000000000f && Score < 1000000000000000000000000f) //Format Sextillion
        {
            numStr = Score / 1000000000000000000000f;
            suffix = "s";
        }
        else if (Score >= 1000000000000000000000000f && Score < 1000000000000000000000000000f) //Format Septillion
        {
            numStr = Score / 1000000000000000000000000f;
            suffix = "S";
        }
        else if (Score >= 1000000000000000000000000000f && Score < 1000000000000000000000000000000f) //Format Octillion
        {
            numStr = Score / 1000000000000000000000000000f;
            suffix = "O";
        }
        else if (Score >= 1000000000000000000000000000000f && Score < 1000000000000000000000000000000000f) //Format Nonillion
        {
            numStr = Score / 1000000000000000000000000000000f;
            suffix = "N";
        }
        else if (Score >= 1000000000000000000000000000000000f) //Format Decillion
        {
            numStr = Score / 1000000000000000000000000000000000f;
            suffix = "D";
        }

        return numStr.ToString("0.000") + " " + suffix;
    }

    public TMP_Text MultiplePurchaseText;
    private int timesClicked = 0;
    public void HandlePurchaseMultiple()
    {
        switch(timesClicked)
        {
            case 4:
                MultiplePurchaseText.text = "X100";
                timesClicked = 0;
                break;
            case 3:
                MultiplePurchaseText.text = "X50";
                timesClicked++;
                break;
            case 2:
                MultiplePurchaseText.text = "X25";
                timesClicked++;
                break;
            case 1:
                MultiplePurchaseText.text = "X10";
                timesClicked++;
                break;
            default:
                MultiplePurchaseText.text = "X1";
                timesClicked++;
                break;
        }
    }

/*    timesClicked++;

        if (timesClicked == 0)
        {
            MultiplePurchaseText.text = "X1";
        }
        else if(timesClicked == 1)
        {
            MultiplePurchaseText.text = "X10";
        }
        else if (timesClicked == 2)
        {
            MultiplePurchaseText.text = "X25";
        }
        else if (timesClicked == 3)
        {
            MultiplePurchaseText.text = "X50";
        }
        else if (timesClicked == 4)
        {
            MultiplePurchaseText.text = "X100";
            timesClicked = 0;
        }*/
}
