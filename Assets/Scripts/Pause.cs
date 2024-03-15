using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject panelPause;
    private GameObject panelscore;
    private GameObject panelset;
    private GameObject gameover1;
    public float totalTime = 60f;
    private float timeRemaining;
    public TMP_Text timerText;
    public TMP_Text score;
    public TMP_Text scorepaneltxt;
    public TMP_Text gameover;
    private int scoretxt = 0;

    void Start()
    {
        timeRemaining = totalTime;
        score.text = "0Pts";
    }

    // Update is called once per frame
    void Update()
    {

        if (timeRemaining > 0f)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = Mathf.Round(timeRemaining).ToString() +"s";
        }
        else
        {
            gameover1.SetActive(true);
            gameover.text = "Score : "+score.text;
            Time.timeScale = 0f;
        }
    }
   
    private void Awake()
    {
        Time.timeScale = 1f;
        panelPause = GameObject.FindGameObjectWithTag("PanelPause");
        panelPause.SetActive(false);
        gameover1 = GameObject.FindGameObjectWithTag("GameOver");
        gameover1.SetActive(false);
        panelscore = GameObject.FindGameObjectWithTag("ScoreTag");
        panelscore.SetActive(false);
        panelset = GameObject.FindGameObjectWithTag("Settings");
        panelset.SetActive(false);
    }

    public void PauseButton()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        panelPause.SetActive(false);
        panelscore.SetActive(false);
        panelset.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void IncrementScore()
    {
        scoretxt++;
        score.text = scoretxt.ToString()+"Pts";
    }

    public void ScorePanel()
    {
        Time.timeScale = 0f;
        panelscore.SetActive(true);
        scorepaneltxt.text = "Score Actuel : "+score.text;
    }

    public void SettingsPanel()
    {
        Time.timeScale = 0f;
        panelset.SetActive(true);
    }
}







