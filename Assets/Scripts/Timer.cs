using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public bool backwards;
    [Tooltip("if it's backwards set the timer here")] public float time;
    private int minutes, seconds, cents;
    private float initialTime;

    [SerializeField] private Animator Door;
    [SerializeField] private TMP_Text abiertaCerrado;
    [SerializeField] private TMP_Text puntuacion;

    private bool isDoorOpen = false;
    private float doorOpenCountdown = 15f;
    private int maxScore = 1000;

    void Start()
    {
        initialTime = time;
    }

    void Update()
    {
        if (abiertaCerrado.text == "OPEN")
        {
            isDoorOpen = true;
            return;
        }
        if (isDoorOpen)
        {
            doorOpenCountdown -= Time.deltaTime;
            if (doorOpenCountdown <= 0)
            {
                LoadNextScene();
            }
            return;
        }


        if (backwards == true)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                time = 0;
                LoadNextScene();
            }
        }
        else
        {
            time += Time.deltaTime;
        }

        minutes = (int)(time / 60f);
        seconds = (int)(time - minutes * 60f);
        cents = (int)((time - (int)time) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);

        UpdateScore();
    }

    void UpdateScore()
    {
        float proportion = time / initialTime;
        int score = (int)(proportion * maxScore);
        puntuacion.text = score.ToString();
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}
