using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generateur : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToGenerate;
    public GameObject hor;
    public GameObject ball;
    public int numberOfObjects = 2;
    private float timer = 0f;
    private float interval = 5f;
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float randomX = Random.Range(-106f, 85f);
            float randomY = Random.Range(-13f, 20f);
            Vector3 randomPosition = new Vector3(randomX, randomY, 90f);
            Instantiate(objectToGenerate, randomPosition, objectToGenerate.transform.rotation);
        }
        for (int i = 0; i < 1; i++)
        {
            float randomX = Random.Range(-55f, 30f);
            float randomY = Random.Range(-21f, 2f);
            Vector3 randomPosition = new Vector3(randomX, randomY, 90f);
            Instantiate(hor, randomPosition, hor.transform.rotation);
        }

        float randomXball = Random.Range(-100f, 80f);
        float randomYball = Random.Range(40f, 45f);
        Vector3 randomPositionball = new Vector3(randomXball, randomYball, 90f);
        Instantiate(ball, randomPositionball, hor.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            float randomX = Random.Range(-100f, 80f);
            float randomY = Random.Range(40f, 45f);
            Vector3 randomPosition = new Vector3(randomX, randomY, 90f);
            Instantiate(ball, randomPosition, hor.transform.rotation);

            timer = 0f; 
        }
    }
}
