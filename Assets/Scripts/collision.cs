using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using TMPro;

public class collision : MonoBehaviour
{
    public float xPosition = 1f; // is x position
    public float yPosition = 1f; // is y position
    public float xSpeed = 1f; // speed
    public float ySpeed = 1f; // speed
    public TMP_Text scoreField;
    public float LeftScore; // stores the score of the left player
    public float RightScore; // stores the code of the right player
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f); // moves the ball to the center of the playing field
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime; // 
        yPosition = yPosition + ySpeed * Time.deltaTime; //
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("top")) // checks if it hit the top or bottom collision and changes orientation.
        {
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("right")) // checks if it hit the right collision object 
        {
            xPosition = 0f; yPosition = 0f; // moves to center
            LeftScore++; // adds 1 to the leftscore variable
            scoreField.text = LeftScore + " - " + RightScore; // updates the score screen
        }
        else if (collision.gameObject.CompareTag("left")) // checks if it hit the left collision object
        {
            RightScore++; // adds 1 to the rightscore variable
            xPosition = 0f; yPosition = 0f; // moves to center
            scoreField.text = LeftScore + " - " + RightScore; // updates the score screen
        }
        else if (collision.gameObject.CompareTag ("paddle right")) // checks if it hit one of the paddles
        {
            xSpeed = xSpeed * -1f; // changes the orientation of the ball
        }
    }
}
