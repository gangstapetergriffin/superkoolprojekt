using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using TMPro;

public class collision : MonoBehaviour
{
    public float xPosition = 1f;
    public float yPosition = 1f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    public TMP_Text scoreField;
    public float LeftScore;
    public float RightScore;
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
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("right"))
        {
            xPosition = 0f; yPosition = 0f;
            LeftScore++;
            scoreField.text = LeftScore + " - " + RightScore;
        }
        else if (collision.gameObject.CompareTag("left"))
        {
            RightScore++;
            xPosition = 0f; yPosition = 0f;
        }
        else if (collision.gameObject.CompareTag ("paddle right"))
        {
            xSpeed = xSpeed * -1.1f;
        }
    }
}
