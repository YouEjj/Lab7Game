using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DestructBall : MonoBehaviour
{
    // Start is called before the first frame update
    private int score = 0;
    public TMP_Text scoretxt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            Destroy(gameObject);
            score++;
            GameObject.FindGameObjectWithTag("Score").GetComponent<Pause>().IncrementScore();

        }
    }
}
