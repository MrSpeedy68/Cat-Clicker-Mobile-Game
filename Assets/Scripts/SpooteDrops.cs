using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpooteDrops : MonoBehaviour
{
    CatClick catClick;
    public GameObject SpooteCan;
    private Camera cam;

    public int SpooteAmount = 0;
    public TMP_Text SpooteAmountText;

    public GameObject CatButton;
    void Start()
    {
        cam = Camera.main;
        catClick = CatButton.GetComponent<CatClick>(); //Find The Main cat click script
        SpooteAmountText.text = "" + SpooteAmount;
    }

    public void DropSpooteCan()
    {
        Vector3 DropPoint = new Vector3();
        DropPoint = cam.ScreenToWorldPoint(new Vector3(Random.Range(cam.pixelWidth, 0f), cam.pixelHeight - 5f, cam.nearClipPlane + 1f)); //make a new Vector2
        Instantiate(SpooteCan, DropPoint, Quaternion.identity); //Create new Spoote Can at that Vector2

        catClick.AmountTillNextSpooteCan = Random.Range(10, 20);
    }

    public void AddSpoot()
    {
        SpooteAmount++;
    }

    void Update()
    {
        SpooteAmountText.text = "" + SpooteAmount;
    }
}
