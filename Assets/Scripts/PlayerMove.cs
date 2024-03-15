using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform player;
    public GameObject playerForce;
    public float moveSpeed = 5f;
    public GameObject fire;
    public float forceMultiplier = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 mousePosition = Input.mousePosition;
            Vector2 canvasPosition = mousePosition;

            if (canvasPosition.x >= 16.80f && canvasPosition.x <= 708f &&
            canvasPosition.y >= 97.40f && canvasPosition.y <= 377.40f)
            {
                GameObject fireball = Instantiate(fire, new Vector3(player.transform.position.x, player.transform.position.y + 20f, 90f), fire.transform.rotation);

                Rigidbody2D rb2D = fireball.GetComponent<Rigidbody2D>();
                if (rb2D != null)
                {

                    Vector2 direction = (canvasPosition - new Vector2(fireball.transform.position.x, fireball.transform.position.y)).normalized;


                    if (mousePosition.x < Screen.width / 2)
                    {
                        rb2D.AddForce(new Vector2(direction.x * -2000f, direction.y * 1300f));
                    }
                    else
                    {
                        rb2D.AddForce(direction * 1500f);
                    }
                }
            }
        }
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
        //player.transform.Translate(Vector3.up * 1500f * Time.deltaTime);
        playerForce.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 400f);

    }

    public void Fire()
    {

        //GameObject fireball = Instantiate(fire, new Vector3(player.transform.position.x, -1.5f, 90f), fire.transform.rotation);
        //fireball.transform.Translate(Vector3.up * 2500f * Time.deltaTime);

        GameObject fireball = Instantiate(fire, new Vector3(player.transform.position.x, player.transform.position.y+ 20f, 90f), fire.transform.rotation);
        Rigidbody2D rb2D = fireball.GetComponent<Rigidbody2D>();
        if (rb2D != null)
        {
            rb2D.AddForce(Vector2.up * 1500f);
        }

    }
}
