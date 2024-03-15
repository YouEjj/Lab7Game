using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructFireBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("OBS") || collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("mur"))
        {
            Destroy(gameObject);
        }
    }
}
