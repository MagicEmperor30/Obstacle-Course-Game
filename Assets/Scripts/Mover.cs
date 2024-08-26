using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

    }
    void PrintInstruction(){
        Debug.Log("Welcome to the game!");
        Debug.Log("Use WASD for movements of Player");
        Debug.Log("Don't hit the Wall's");

    }
    void PlayerMovement(){
        float xValue =  Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * MoveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}
