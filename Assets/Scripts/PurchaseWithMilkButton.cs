using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PurchaseWithMilkButton : MonoBehaviour
{
    SpooteDrops spooteDrops;
    public GameObject GameEventManager;

    public TMP_Text spootePriceLabel; //How much spoote cans it costs to purchase
    public int spooteCostAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
        spooteDrops = GameEventManager.GetComponent<SpooteDrops>();
        spootePriceLabel.text = "" + spooteCostAmount;
    }

    public void SpooteButtonClicked()
    {
        if (spooteCostAmount <= spooteDrops.SpooteAmount)
        {
            spooteDrops.SpooteAmount -= spooteCostAmount;
            Debug.Log("You Have spent your Spoot");
        }
        else Debug.Log("You dont have enough spoot my friend");
    }




}
