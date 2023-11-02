using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddlemultiplayer : MonoBehaviour
{
    public enum PaddleType { Left, Right } // makes a thing so you can select right or left on the object with the script
    public PaddleType paddleType; // gives paddleType the value selected in PaddleType per object
    public float speed = 3f; // the max speed the paddle is allowed to move
    public float maxValue = 3f; // the max height the paddle is allowed to move
    private bool movingUp = true; // a bool to make the computer player work

    void Update()
    {
        if (paddleType == PaddleType.Left) //checks if the object has the value Left selected
        {
            if (movingUp) // checks if movingUp is true
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime); // moves the paddle up
                if (transform.position.y >= maxValue) // checks if the papddle has hit the max value
                {
                    movingUp = false; // changes the movingUp bool to false
                }
            }
            else
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime); // moves the paddle down
                if (transform.position.y <= -maxValue) // checks if the paddle has hit the negative max value
                {
                    movingUp = true; // changes the movingUp bool to true
                }
            }
        }
        else if (paddleType == PaddleType.Right) //checks if the object has the value Right selected
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxValue) // checks if the key w is pushed and if the position isn't above the maxValue
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime); // moves the paddle up
            }
            else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -maxValue) // checks if the key s is pushed and if the position isn't below the maxValue
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime); // moves the paddle down
            }
        }
    }
}
