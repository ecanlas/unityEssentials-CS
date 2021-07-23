using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintStartNotification();   
    }

    // Update is called once per frame
    void Update()
    {   
        movePlayer();

    }

    void PrintStartNotification(){
        Debug.Log("wassup");
        Debug.Log("avoid obstacles");
        Debug.Log("Don't hit the walls");
    }

    void movePlayer(){
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }


}
