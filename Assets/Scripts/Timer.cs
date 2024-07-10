using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public bool backwards;
    [Tooltip("if it's backwards set the timer here")] public float time;
    private int minutes, seconds, cents;

    // Update is called once per frame
    void Update()
    {
        if (backwards == true)
        {
            time -= Time.deltaTime;
            if (time < 0) time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }

        minutes = (int)(time / 60f);
        seconds = (int)(time - minutes * 60f);
        cents = (int)((time - (int)time) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);
    }
}
