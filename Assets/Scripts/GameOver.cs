using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject over;
    public TMP_Text gameover;
    public TMP_Text score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        if (Mathf.Abs(Quaternion.Angle(rectTransform.rotation, Quaternion.Euler(0, 0, 90))) < 0.01f ||
        Mathf.Abs(Quaternion.Angle(rectTransform.rotation, Quaternion.Euler(0, 0, -90))) < 0.01f)
        {
            
            over.SetActive(true);
            Time.timeScale = 0f;
            gameover.text = "Score : " + score.text;

        }
    }

    public void Replay2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
