using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawMovement : MonoBehaviour
{
    public float initialValue;
    public float finalValue;
    private float Position;
    private bool movement;
    public float freezingSpeed;
    public float speed = 2f;


    public bool zUse;
   

    private void Update()
    {
        transform.Rotate(new Vector3(0, freezingSpeed * Time.deltaTime, 0));
        if (Position >= finalValue)
        {
            movement = false;
        }

        if (Position <= initialValue)
        {
            movement = true;
        }


        if (zUse)
        {
            Position = transform.position.z;
            MovementZ();

        }
        else
        {
            Position = transform.position.x;
            MovementX();
        }
       

       

    }


    private void MovementX()
    {
        
            if (movement == true)
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

            }
            else
            {
                transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);

            }
        
    }


    private void MovementZ()
    {

        if (movement == true)
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        }
        else
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);

        }

    }

}
