using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float xPosition = 1f;
    public float yPosition = 1f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("top"))
        {
            Debug.Log("hit top or bottom");
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("right"))
        {
            Debug.Log("hit right or left");
            xPosition = 0f; yPosition = 0f;
        }
        else if (collision.gameObject.CompareTag ("paddle right"))
        {
            xSpeed = xSpeed * -1f;
        }
    }
}
