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
        tabbyCatLevel = PlayerPrefs.GetInt("tabbyCatLevel", 0);
        tabbyCatProduction = PlayerPrefs.GetFloat("tabbyCatProduction", 0f);
        tabbyCatPrice = PlayerPrefs.GetFloat("tabbyCatPrice", 20f);
        tabbyCatProdIncrease = PlayerPrefs.GetFloat("tabbyCatProdIncrease", 0.1f);

        //Load Chonker Upgrade
        abyssinianCatLevel = PlayerPrefs.GetInt("abyssinianCatLevel", 0);
        abyssinianCatProduction = PlayerPrefs.GetFloat("abyssinianCatProduction", 0f);
        abyssinianCatPrice = PlayerPrefs.GetFloat("abyssinianCatPrice", 100f);
        abyssinianCatProdIncrease = PlayerPrefs.GetFloat("abyssinianCatProdIncrease", 1f);

        //Load Bee Cat Upgrade
        munchkinCatLevel = PlayerPrefs.GetInt("munchkinCatLevel", 0);
        munchkinCatProduction = PlayerPrefs.GetFloat("munchkinCatProduction", 0f);
        munchkinCatPrice = PlayerPrefs.GetFloat("munchkinCatPrice", 1000f);
        munchkinCatProdIncrease = PlayerPrefs.GetFloat("munchkinCatProdIncrease", 9f);

        //Load Lasagne Boy Upgrade
        siameseCatLevel = PlayerPrefs.GetInt("siameseCatLevel", 0);
        siameseCatProduction = PlayerPrefs.GetFloat("siameseCatProduction", 0f);
        siameseCatPrice = PlayerPrefs.GetFloat("siameseCatPrice", 12500f);
        siameseCatProdIncrease = PlayerPrefs.GetFloat("siameseCatProdIncrease", 50f);

        //Load Pirate Cat Upgrade
        scottishFoldCatLevel = PlayerPrefs.GetInt("scottishFoldCatLevel", 0);
        scottishFoldCatProduction = PlayerPrefs.GetFloat("scottishFoldCatProduction", 0f);
        scottishFoldCatPrice = PlayerPrefs.GetFloat("scottishFoldCatPrice", 125000f);
        scottishFoldCatProdIncrease = PlayerPrefs.GetFloat("scottishFoldCatProdIncrease", 250f);

        //Load Spy Cat Upgrade
        sphynxCatLevel = PlayerPrefs.GetInt("sphynxCatLevel", 0);
        sphynxCatProduction = PlayerPrefs.GetFloat("sphynxCatProduction", 0f);
        sphynxCatPrice = PlayerPrefs.GetFloat("sphynxCatPrice", 1500000f);
        sphynxCatProdIncrease = PlayerPrefs.GetFloat("sphynxCatProdIncrease", 1300f);

        //Load Inbread Cat Upgrade
        ragdollCatLevel = PlayerPrefs.GetInt("ragdollCatLevel", 0);
        ragdollCatProduction = PlayerPrefs.GetFloat("ragdollCatProduction", 0f);
        ragdollCatPrice = PlayerPrefs.GetFloat("ragdollCatPrice", 20000000f);
        ragdollCatProdIncrease = PlayerPrefs.GetFloat("ragdollCatProdIncrease", 7500f);

        //Load Void Cat Upgrade
        maineCoonCatLevel = PlayerPrefs.GetInt("maineCoonCatLevel", 0);
        maineCoonCatProduction = PlayerPrefs.GetFloat("maineCoonCatProduction", 0f);
        maineCoonCatPrice = PlayerPrefs.GetFloat("maineCoonCatPrice", 320000000f);
        maineCoonCatProdIncrease = PlayerPrefs.GetFloat("maineCoonCatProdIncrease", 45000f);
    }

    public void Save()
    {
        //Save Kitten Upgrade
        PlayerPrefs.SetInt("tabbyCatLevel", tabbyCatLevel);
        PlayerPrefs.SetFloat("tabbyCatProduction", tabbyCatProduction);
        PlayerPrefs.SetFloat("tabbyCatPrice", tabbyCatPrice);
        PlayerPrefs.SetFloat("tabbyCatProdIncrease", tabbyCatProdIncrease);

        //Save Chonker Upgrade
        PlayerPrefs.SetInt("abyssinianCatLevel", abyssinianCatLevel);
        PlayerPrefs.SetFloat("abyssinianCatProduction", abyssinianCatProduction);
        PlayerPrefs.SetFloat("abyssinianCatPrice", abyssinianCatPrice);
        PlayerPrefs.SetFloat("abyssinianCatProdIncrease", abyssinianCatProdIncrease);

        //Save Bee Cat Upgrade
        PlayerPrefs.SetInt("munchkinCatLevel", munchkinCatLevel);
        PlayerPrefs.SetFloat("munchkinCatProduction", munchkinCatProduction);
        PlayerPrefs.SetFloat("munchkinCatPrice", munchkinCatPrice);
        PlayerPrefs.SetFloat("munchkinCatProdIncrease", munchkinCatProdIncrease);

        //Save Lasagne Boy Upgrade
        PlayerPrefs.SetInt("siameseCatLevel", siameseCatLevel);
        PlayerPrefs.SetFloat("siameseCatProduction", siameseCatProduction);
        PlayerPrefs.SetFloat("siameseCatPrice", siameseCatPrice);
        PlayerPrefs.SetFloat("siameseCatProdIncrease", siameseCatProdIncrease);

        //Save Pirate Cat Upgrade
        PlayerPrefs.SetInt("scottishFoldCatLevel", scottishFoldCatLevel);
        PlayerPrefs.SetFloat("scottishFoldCatProduction", scottishFoldCatProduction);
        PlayerPrefs.SetFloat("scottishFoldCatPrice", scottishFoldCatPrice);
        PlayerPrefs.SetFloat("scottishFoldCatProdIncrease", scottishFoldCatProdIncrease);

        //Save Spy Cat Upgrade
        PlayerPrefs.SetInt("sphynxCatLevel", sphynxCatLevel);
        PlayerPrefs.SetFloat("sphynxCatProduction", sphynxCatProduction);
        PlayerPrefs.SetFloat("sphynxCatPrice", sphynxCatPrice);
        PlayerPrefs.SetFloat("sphynxCatProdIncrease", sphynxCatProdIncrease);

        //Save Inbread Cat Upgrade
        PlayerPrefs.SetInt("ragdollCatLevel", ragdollCatLevel);
        PlayerPrefs.SetFloat("ragdollCatProduction", ragdollCatProduction);
        PlayerPrefs.SetFloat("ragdollCatPrice", ragdollCatPrice);
        PlayerPrefs.SetFloat("ragdollCatProdIncrease", ragdollCatProdIncrease);

        //Save Void Cat Upgrade
        PlayerPrefs.SetInt("maineCoonCatLevel", maineCoonCatLevel);
        PlayerPrefs.SetFloat("maineCoonCatProduction", maineCoonCatProduction);
        PlayerPrefs.SetFloat("maineCoonCatPrice", maineCoonCatPrice);
        PlayerPrefs.SetFloat("maineCoonCatProdIncrease", maineCoonCatProdIncrease);

    }


    // Start is called before the first frame update
    void Start()
    {
        //Load();

        FloatingTextController.Initialize();

        catClick = CatButton.GetComponent<CatClick>(); //Find The Main cat click script

        abyssinianCatPriceText.text = "" + UpgradesFormatting(abyssinianCatPrice); //Initialize PriceTag
        abyssinianCatLevelText.text = "" + abyssinianCatLevel; //Initialize LevelTag

        tabbyCatPriceText.text = "" + UpgradesFormatting(tabbyCatPrice);
        tabbyCatLevelText.text = "" + tabbyCatLevel;

        munchkinCatPriceText.text = "" + UpgradesFormatting(munchkinCatPrice);
        munchkinCatLevelText.text = "" + munchkinCatLevel;

        siameseCatPriceText.text = "" + UpgradesFormatting(siameseCatPrice);
        siameseCatLevelText.text = "" + siameseCatLevel;

        scottishFoldCatPriceText.text = "" + UpgradesFormatting(scottishFoldCatPrice);
        scottishFoldCatLevelText.text = "" + scottishFoldCatLevel;

        sphynxCatPriceText.text = "" + UpgradesFormatting(sphynxCatPrice);
        sphynxCatLevelText.text = "" + sphynxCatLevel;

        ragdollCatPriceText.text = "" + UpgradesFormatting(ragdollCatPrice);
        ragdollCatLevelText.text = "" + ragdollCatLevel;

        maineCoonCatPriceText.text = "" + UpgradesFormatting(maineCoonCatPrice);
        maineCoonCatLevelText.text = "" + maineCoonCatLevel;

        persianCatPriceText.text = "" + UpgradesFormatting(persianCatPrice);
        persianCatLevelText.text = "" + persianCatLevel;

        norwegianForestCatPriceText.text = "" + UpgradesFormatting(norwegianForestCatPrice);
        norwegianForestCatLevelText.text = "" + norwegianForestCatLevel;

        bengalCatPriceText.text = "" + UpgradesFormatting(bengalCatPrice);
        bengalCatLevelText.text = "" + bengalCatLevel;

        savannahCatPriceText.text = "" + UpgradesFormatting(savannahCatPrice);
        savannahCatLevelText.text = "" + savannahCatLevel;

        InvokeRepeating("ProductionPerSecond", 0f, 1.0f); //Run the production every second.
        InvokeRepeating("Save", 0f, 5f); //Call the Save method every 5 seconds
    }

    //---------------Shop Menu---------------

    //Tabby Cat Upgrade
    private int tabbyCatLevel = 0;
    private float tabbyCatProduction = 0f;
    private float tabbyCatPrice = 20f;
    private float tabbyCatProdIncrease = 0.1f;
    public float tabbyCatMultiplyer = 1;
    public TMP_Text tabbyCatPriceText;
    public TMP_Text tabbyCatLevelText;
    public GameObject greyOutImageAbyssinian;

    public void TabbyCatButton()
    {
        UpgradesMethod(ref tabbyCatLevel, ref tabbyCatProduction, ref tabbyCatPrice, ref tabbyCatProdIncrease, ref tabbyCatMultiplyer, ref tabbyCatPriceText, ref tabbyCatLevelText);

        greyOutImageAbyssinian.SetActive(false);
    }

    //Abyssinian Cat Upgrade
    private int abyssinianCatLevel = 0; //What Level it current is
    private float abyssinianCatProduction = 0f; //How much score it produces per second
    private float abyssinianCatPrice = 100f; //Its current price
    private float abyssinianCatProdIncrease = 1f; //The amount of production increase per level
    public float abyssinianCatMultiplayer = 1;
    public TMP_Text abyssinianCatPriceText;
    public TMP_Text abyssinianCatLevelText;

    public void AbyssinianCatButton()
    {
        UpgradesMethod(ref abyssinianCatLevel, ref abyssinianCatProduction, ref abyssinianCatPrice, ref abyssinianCatProdIncrease, ref abyssinianCatMultiplayer, ref abyssinianCatPriceText, ref abyssinianCatLevelText);
    }

    //Munchkin Cat Upgrade
    private int munchkinCatLevel = 0;
    private float munchkinCatProduction = 0f;
    private float munchkinCatPrice = 1000f;
    private float munchkinCatProdIncrease = 7f;
    public float munchkinCatMultiplayer = 1;
    public TMP_Text munchkinCatPriceText;
    public TMP_Text munchkinCatLevelText;

    public void MunchkinCatButton()
    {
        UpgradesMethod(ref munchkinCatLevel, ref munchkinCatProduction, ref munchkinCatPrice, ref munchkinCatProdIncrease, ref munchkinCatMultiplayer, ref munchkinCatPriceText, ref munchkinCatLevelText);
    }

    //Siamese Cat Upgrade
    private int siameseCatLevel = 0;
    private float siameseCatProduction = 0f;
    private float siameseCatPrice = 12500f;
    private float siameseCatProdIncrease = 50f;
    public float siameseCatMultiplayer = 1;
    public TMP_Text siameseCatPriceText;
    public TMP_Text siameseCatLevelText;

    public void SiameseCatButton()
    {
        UpgradesMethod(ref siameseCatLevel, ref siameseCatProduction, ref siameseCatPrice, ref siameseCatProdIncrease, ref siameseCatMultiplayer, ref siameseCatPriceText, ref siameseCatLevelText);
    }

    //Scottish Fold Cat Upgrade
    private int scottishFoldCatLevel = 0;
    private float scottishFoldCatProduction = 0f;
    private float scottishFoldCatPrice = 125000f;
    private float scottishFoldCatProdIncrease = 250f;
    public float scottishFoldCatMultiplayer = 1;
    public TMP_Text scottishFoldCatPriceText;
    public TMP_Text scottishFoldCatLevelText;

    public void ScottishFoldCatButton()
    {
        UpgradesMethod(ref scottishFoldCatLevel, ref scottishFoldCatProduction, ref scottishFoldCatPrice, ref scottishFoldCatProdIncrease, ref scottishFoldCatMultiplayer, ref scottishFoldCatPriceText, ref scottishFoldCatLevelText);
    }
    
    //Sphynx Cat Upgrade
    private int sphynxCatLevel = 0;
    private float sphynxCatProduction = 0f;
    private float sphynxCatPrice = 1500000f;
    private float sphynxCatProdIncrease = 1500f;
    public float sphynxCatMultiplayer = 1;
    public TMP_Text sphynxCatPriceText;
    public TMP_Text sphynxCatLevelText;

    public void SphynxCatButton()
    {
        UpgradesMethod(ref sphynxCatLevel, ref sphynxCatProduction, ref sphynxCatPrice, ref sphynxCatProdIncrease, ref sphynxCatMultiplayer, ref sphynxCatPriceText, ref sphynxCatLevelText);
    }

    //Ragdoll Cat Upgrade
    private int ragdollCatLevel = 0;
    private float ragdollCatProduction = 0f;
    private float ragdollCatPrice = 20000000f;
    private float ragdollCatProdIncrease = 7600f;
    public float ragdollCatMultiplayer = 1;
    public TMP_Text ragdollCatPriceText;
    public TMP_Text ragdollCatLevelText;

    public void RagdollCatButton()
    {
        UpgradesMethod(ref ragdollCatLevel, ref ragdollCatProduction, ref ragdollCatPrice, ref ragdollCatProdIncrease, ref ragdollCatMultiplayer, ref ragdollCatPriceText, ref ragdollCatLevelText);
    }

    //Maine Coon Cat Upgrade
    private int maineCoonCatLevel = 0;
    private float maineCoonCatProduction = 0f;
    private float maineCoonCatPrice = 320000000;
    private float maineCoonCatProdIncrease = 43000f;
    public float maineCoonCatMultiplayer = 1;
    public TMP_Text maineCoonCatPriceText;
    public TMP_Text maineCoonCatLevelText;

    public void MaineCoonCatButton()
    {
        UpgradesMethod(ref maineCoonCatLevel, ref maineCoonCatProduction, ref maineCoonCatPrice, ref maineCoonCatProdIncrease, ref maineCoonCatMultiplayer, ref maineCoonCatPriceText, ref maineCoonCatLevelText);
    }

    //Persian Cat Upgrades
    private int persianCatLevel = 0;
    private float persianCatProduction = 0f;
    private float persianCatPrice = 5000000000f;
    private float persianCatProdIncrease = 250000f;
    public float persianCatMultiplayer = 1;
    public TMP_Text persianCatPriceText;
    public TMP_Text persianCatLevelText;

    public void PersianCatButton()
    {
        UpgradesMethod(ref persianCatLevel, ref persianCatProduction, ref persianCatPrice, ref persianCatProdIncrease, ref persianCatMultiplayer, ref persianCatPriceText, ref persianCatLevelText);
    }

    //Norwegian Forest Cat Upgrades
    private int norwegianForestCatLevel = 0;
    private float norwegianForestCatProduction = 0f;
    private float norwegianForestCatPrice = 75000000000f;
    private float norwegianForestCatProdIncrease = 1600000f;
    public float norwegianForestCatMultiplayer = 1;
    public TMP_Text norwegianForestCatPriceText;
    public TMP_Text norwegianForestCatLevelText;

    public void NorwegianForestCatButton()
    {
        UpgradesMethod(ref norwegianForestCatLevel, ref norwegianForestCatProduction, ref norwegianForestCatPrice, ref norwegianForestCatProdIncrease, ref norwegianForestCatMultiplayer, ref norwegianForestCatPriceText, ref norwegianForestCatLevelText);
    }

    //Bengal Cat Upgrades
    private int bengalCatLevel = 0;
    private float bengalCatProduction = 0f;
    private float bengalCatPrice = 1000000000000f;
    private float bengalCatProdIncrease = 10000000f;
    public float bengalCatMultiplayer = 1;
    public TMP_Text bengalCatPriceText;
    public TMP_Text bengalCatLevelText;

    public void BengalCatButton()
    {
        UpgradesMethod(ref bengalCatLevel, ref bengalCatProduction, ref bengalCatPrice, ref bengalCatProdIncrease, ref bengalCatMultiplayer, ref bengalCatPriceText, ref bengalCatLevelText);
    }

    //Savannah Cat Upgrades
    private int savannahCatLevel = 0;
    private float savannahCatProduction = 0f;
    private float savannahCatPrice = 15000000000000f;
    private float savannahCatProdIncrease = 75000000f;
    public float savannahCatMultiplayer = 1;
    public TMP_Text savannahCatPriceText;
    public TMP_Text savannahCatLevelText;

    public void SavannahCatButton()
    {
        UpgradesMethod(ref savannahCatLevel, ref savannahCatProduction, ref savannahCatPrice, ref savannahCatProdIncrease, ref savannahCatMultiplayer, ref savannahCatPriceText, ref savannahCatLevelText);
    }

    //----------------------------------------------------------------------------------------------------------------------------------------------------\\

    //Generalised method for upgrades
    public void UpgradesMethod(ref int Level, ref float Production, ref float Price, ref float ProdIncrease, ref float Multiplyer, ref TMP_Text PriceText, ref TMP_Text LevelText)
    {
        if (catClick.Score != 0 && catClick.Score >= Price)
        {
            catClick.Score -= Price;

            Level++;
            Production = (ProdIncrease * Level) * Multiplyer;
            Price = Mathf.Ceil(100 * Mathf.Pow(GlobalMultiplyer, Level));

            PriceText.text = "" + UpgradesFormatting(Price);
            LevelText.text = "" + Level;
        }
        else Debug.Log("Broke");
    }

    /*    public void UpdateCurrentPrice(ref float Production, ref float ProdIncrease, ref int Level, ref float Multiplyer)
        {
            Production = (ProdIncrease * Level) * Multiplyer;
        }*/

    public void UpdateCurrentPrice()
    {
        tabbyCatProduction = (tabbyCatProdIncrease * tabbyCatLevel) * tabbyCatMultiplyer;
    }

    public TMP_Text ScorePerSecond;
    //Calculates the total production per second.
    public double ProductionPerSecond()
    {
        float TotalProduction = tabbyCatProduction + abyssinianCatProduction + munchkinCatProduction + siameseCatProduction + scottishFoldCatProduction + sphynxCatProduction + ragdollCatProduction + maineCoonCatProduction;
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
}
