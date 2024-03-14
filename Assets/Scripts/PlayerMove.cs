using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform player;
    public float moveSpeed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveRight()
    {
        player.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);


    }

    public void MoveLeft()
    {
        player.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    public void Jump()
    {
        player.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
}
