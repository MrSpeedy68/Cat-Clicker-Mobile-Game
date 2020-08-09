using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;

public class FloatingTextController : MonoBehaviour
{
    private static FloatingScoreText popupTextPrefab;
    private static GameObject canvas;

    public static void Initialize()
    {
        canvas = GameObject.Find("InGameUIOverlay");
        if (!popupTextPrefab)
        {
            popupTextPrefab = Resources.Load<FloatingScoreText>("Prefabs/PopupTextParent");
        }
    }

    public static void CreateFloatingText(string text, Vector3 location)
    {
        FloatingScoreText instance = Instantiate(popupTextPrefab, location, Quaternion.identity);
        //Vector2 screenPosition = Camera.main.WorldToScreenPoint(location.position);
        instance.transform.SetParent(canvas.transform, false);
        //instance.transform.position = screenPosition;
        instance.SetText(text);
        Debug.Log("Stinky");
    }
}
