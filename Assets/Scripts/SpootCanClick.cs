using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpootCanClick : MonoBehaviour
{
    SpooteDrops spooteDrops;

    private void Start()
    {
        spooteDrops = FindObjectOfType<SpooteDrops>();
    }

    private void OnMouseDown() //When mouse is clicked
    {
        //spooteDrops = FindObjectOfType<SpooteDrops>(); //Find the SpooteDrops script
        spooteDrops.AddSpoot(); //Run the AddSpoot Method which adds score
        Debug.Log("clicked");
        Destroy(this.gameObject); //Destroy the game object
    }
}
