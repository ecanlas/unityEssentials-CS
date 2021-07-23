using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float zAxis = 0;
    [SerializeField] float yAxis = 0.5f;
    [SerializeField] float xAxis = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAxis,yAxis,zAxis);
    }
}
