using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AdditionalUpgrades : MonoBehaviour
{
    Upgrades upgrades;
    CatClick catClick;
    public GameObject CatButton;
    private float AdditionalUpgradesGlobalMultiplayer = 1.27f;

    // Start is called before the first frame update
    void Start()
    {
        upgrades = gameObject.GetComponent<Upgrades>();
        catClick = CatButton.GetComponent<CatClick>();

        FivePrcntLevelTxt.text = "" + FivePrcntLevel;
        FivePrcntPriceTxt.text = "" + FivePrcntPrice;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int FivePrcntLevel = 0;
    private float FivePrcntPrice = 50f;
    public TMP_Text FivePrcntPriceTxt;
    public TMP_Text FivePrcntLevelTxt;

    public void FivePercentUpgradeButton()
    {
        if(catClick.Score != 0 && catClick.Score >= FivePrcntPrice)
        {
            catClick.Score -= FivePrcntPrice;

            FivePrcntLevel++;
            upgrades.tabbyCatMultiplyer += 0.05f;
            FivePrcntPrice = Mathf.Ceil(100 * Mathf.Pow(AdditionalUpgradesGlobalMultiplayer, FivePrcntLevel));

            upgrades.UpdateCurrentPrice();

            FivePrcntLevelTxt.text = "" + FivePrcntLevel;
            FivePrcntPriceTxt.text = "" + FivePrcntPrice;
        }
    }

}
