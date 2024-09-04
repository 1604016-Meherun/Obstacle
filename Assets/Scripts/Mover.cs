using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

   // [SerializeField] float xValue = 0f;
    //[SerializeField] float yValue = 0f;
    //[SerializeField] float zValue = 0f;

    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!!");
        Debug.Log("Move your player with a,d,s,w or arrow keys");
        Debug.Log("Don't touch the wall");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
