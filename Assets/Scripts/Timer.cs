using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Timer : MonoBehaviour
{
    bool isGameOver = false;
    float timer_f;
    string timerText = "";
    int minute = 0;
    int second = 0;
    TextMeshProUGUI text;
    UnityAction timeupAction;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;
        
        timer_f = Time.time;
        int timer_i = Mathf.FloorToInt(timer_f);
        second = timer_i % 60;
        string minuteText = "";
        string secondText = "";
        if (timer_i >= 60)
        {
            timer_f -= 60f;
            minute = timer_i / 60;
        }
        secondText = (second < 10) ? "0" + second : second + "";
        minuteText = (minute < 10) ? "0" + minute : minute + "";
        text.SetText(minuteText + ":" + secondText);

        if (minute >= 1 && second >= 30)
        {
            timeupAction.Invoke();
        }
    }

    public void setTimeupAction(UnityAction action)
    {
        timeupAction = action;
    }

    public void stopTimer()
    {
        isGameOver = true;
    }
}
