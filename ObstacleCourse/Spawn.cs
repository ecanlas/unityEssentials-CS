using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait;


    void Start() {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        rigidbody.useGravity = false;
        renderer.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait){
            //spawn object
            Debug.Log("Spawning Sphere");
            renderer.enabled = true;
            rigidbody.useGravity = true;

        }
    }

}
