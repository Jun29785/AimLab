using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public float LimitTime;
    public Text score;
    public Text timer;
    public Text Percen;
    public Text bestscore;
    public Text currentscore;
    public Text percentage;
    public GameObject gameoverpanel;
    private void Update()
    {
        if (GameManager1.Instance.IsStarted)
        {
            UpdateText();
            TimerText();
        }

        if (!GameManager1.Instance.IsStarted && gameoverpanel.activeSelf == false)
        {
            gameoverpanel.SetActive(true);
            GameOverText();
        }
    }
    private void GameOverText()
    {
        bestscore.text = GameManager1.Instance.BestScore.ToString("최고점수 : 00000점");
        currentscore.text = GameManager1.Instance.CurrentScore.ToString("점수 : 00000점");
        percentage.text = BAllMan.Instance.percent.ToString("정확도 : 00.00%");
    }
    private void UpdateText()
    {
        score.text = BAllMan.Instance.score.ToString();
        Percen.text = BAllMan.Instance.percent.ToString("00.00%");
    }
    private void TimerText()
    {
        LimitTime -= Time.deltaTime;
        timer.text = Mathf.Round(LimitTime).ToString("00");

        if (LimitTime <= 0)
        {
            GameManager1.Instance.IsStarted = false;
        }
    }
}
