using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public HitButton gameButton;
    internal Quaternion zeroPoint = new Quaternion(0f, 0f, 0f, 0f);
    void Start()
    {
        Instance = this;
    }

    void Update()
    {
        Turn();
    }

    void Turn()
    {
        if (gameButton.TurnValue % 2 == 0)
        {
            transform.Rotate(70 * Time.deltaTime, 0, 0);

        }
        else if (gameButton.TurnValue % 2 == 1)
        {
            transform.Rotate(0, 0, 70 * Time.deltaTime);

        }
    }
}