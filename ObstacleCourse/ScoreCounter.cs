using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;


    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag !="Hit"){
            score++;
            Debug.Log("You bumped into a thing this many times" + score);
        }
        else
        {
            Debug.Log("you already hit that");
        }

    }


}
