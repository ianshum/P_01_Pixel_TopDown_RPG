using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NotificationManager : MonoBehaviour
{
    private bool _isContinueBlockGameAction = false;
    public TextMeshProUGUI text;
    public Animator animator;

    private void Hide()
    {
        animator.SetTrigger("Hide");
        if(_isContinueBlockGameAction)
            GameManager.Instance.IsBlockGameActions = true;
        else
            GameManager.Instance.IsBlockGameActions = false;
    }

    public void Show(string text, bool isContinueBlockGameAction, Color color)
    {
        _isContinueBlockGameAction = isContinueBlockGameAction;
        this.text.text = text;
        this.text.color = color;
        animator.SetTrigger("Show");
        Invoke("Hide", 1.5f);
    }
}
