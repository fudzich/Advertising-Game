using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{

    [SerializeField] private float gameDuration = 60f;  // 1 minutes in seconds
    private float remainingTime;

    [SerializeField] private TextMeshProUGUI timerText; // for UI timer text display
    [SerializeField] private TextMeshProUGUI scoreText; // for UI score text display

    public float RemainingTime => remainingTime;
    public float ElapsedTime => Mathf.Clamp(gameDuration - remainingTime, 0f, gameDuration);

    // Start is called before the first frame update
    void Start()
    {
        remainingTime = gameDuration;
        UpdateTimerUI();
        UpdateScoreUI();
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        UpdateTimerUI();
        UpdateScoreUI();

        if (remainingTime <= 1)
        {
            remainingTime = 1;
            EndGame();
        }
    }

    private void EndGame()
    {
         SceneManager.LoadScene("ScoreScene");
    }

    private void UpdateTimerUI()
    {
        if (timerText != null)
        {
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    private void UpdateScoreUI(){
        if (scoreText != null){
            int score = DataHolder.points;
            scoreText.text = score.ToString();
        }
    }
}
