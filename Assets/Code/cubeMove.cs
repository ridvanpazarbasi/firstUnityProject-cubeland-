using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMove : MonoBehaviour
{
    public float doorSpeed = 1.0f;
    public Vector3 doorMove;
    private bool movStart;
  
   
    void Update()
    {
        if (movStart == true)
        {
            transform.Translate(doorMove * doorSpeed * Time.deltaTime);

        }
        
    }

    public void MoveStart()
    {


        movStart = true;
    }
}
