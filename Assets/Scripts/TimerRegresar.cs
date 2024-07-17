using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerRegresar : MonoBehaviour
{
    public TMP_Text timerText;
    public bool backwards = true;
    [Tooltip("if it's backwards set the timer here")] public float time = 15f;
    private int seconds;

    [SerializeField] private TMP_Text abiertaCerrado;

    private bool isDoorOpen = false;

    void Update()
    {
        if (abiertaCerrado.text == "OPEN")
        {
            isDoorOpen = true;
        }

        if (isDoorOpen)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                LoadNextScene();
            }

            seconds = Mathf.CeilToInt(time);
            timerText.text = string.Format("{0:00}", seconds);
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("FinalMenu");
    }
}
