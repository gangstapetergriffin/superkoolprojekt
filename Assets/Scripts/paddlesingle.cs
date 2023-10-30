using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddlemultiplayer : MonoBehaviour
{
    public enum PaddleType { Left, Right }
    public PaddleType paddleType;
    public float speed = 3f;
    public float maxValue = 3f;
    private bool movingUp = true;

    void Update()
    {
        if (paddleType == PaddleType.Left)
        {
            if (movingUp)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                if (transform.position.y >= maxValue)
                {
                    movingUp = false;
                }
            }
            else
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                if (transform.position.y <= -maxValue)
                {
                    movingUp = true;
                }
            }
        }
        else if (paddleType == PaddleType.Right)
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxValue)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -maxValue)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
}
