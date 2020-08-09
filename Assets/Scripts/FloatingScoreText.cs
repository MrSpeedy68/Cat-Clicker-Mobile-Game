using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FloatingScoreText : MonoBehaviour
{
    public Animator animator;
    private TMP_Text ScoreText;

    void OnEnable()
    {
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipInfo[0].clip.length);
        ScoreText = animator.GetComponent<TMP_Text>();
    }

    public void SetText(string text)
    {
        animator.GetComponent<TMP_Text>().text = text;
    }
}
