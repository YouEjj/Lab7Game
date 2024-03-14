using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject panelPause;
    public float totalTime = 60f;
    private float timeRemaining;
    public TMP_Text timerText;
    public TMP_Text score;

    void Start()
    {
        timeRemaining = totalTime;
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
            //timerText.text = "Time's up!";
        }
    }
   
    private void Awake()
    {
        panelPause = GameObject.FindGameObjectWithTag("PanelPause");
        panelPause.SetActive(false);
    }

    public void PauseButton()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void Score()
    {
       
        score.text = "25Pts";
    }
}







