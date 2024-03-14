using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
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
            Debug.Log("shdjhdjs");
        }
    }


}
