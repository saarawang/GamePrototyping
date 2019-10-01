using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Init(bool isRightPaddle)
    {

        Vector2 pos = Vector2.zero;

        if (isRightPaddle)
        {
            // Place paddle to right of screen
            pos = new Vector2(GameManager.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x; // move a bit to left
        }
        else
        {
            // Place paddle to left of screen
            pos = new Vector2(GameManager.buttomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x; // move a bit to right
        }

        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
