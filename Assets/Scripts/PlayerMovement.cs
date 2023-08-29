using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public const float SPEED = 50f;
    private const string HORIZONTAL_INPUT_KEYWORD = "Horizontal";
    private const string VERTICAL_INPUT_KEYWORD = "Vertical";
    void Update()
    {
       float inputX = Input.GetAxis(HORIZONTAL_INPUT_KEYWORD);
        float inputY = Input.GetAxis(VERTICAL_INPUT_KEYWORD);

        Vector3 movement = new Vector3(SPEED * inputX, SPEED * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);


    }
}
