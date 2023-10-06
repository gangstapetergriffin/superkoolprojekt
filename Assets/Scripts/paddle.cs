using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public enum PaddleType { Left, Right }
    public PaddleType paddleType;
    public float speed = 3f;
    public float maxValue = 3f;

    void Update()
    {
        if (paddleType == PaddleType.Left)
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y < maxValue)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && transform.position.y > -maxValue)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
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
