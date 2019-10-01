using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Ball ball;
    public Paddle paddle;

    public static Vector2 buttomLeft;
    public static Vector2 topRight;

    // Start is called before the first frame update
    void Start()
    {
        // Convert screen pixels coordinates to game coordinates (0, 0)
        buttomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        // Create ball
        Instantiate(ball);

        // Create two paddles
        Paddle paddle1 = Instantiate(paddle) as Paddle;
        Paddle paddle2 = Instantiate(paddle) as Paddle;
        paddle1.Init(true); // Right paddle
        paddle2.Init(false); // LEft paddle
    }

}
