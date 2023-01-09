using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int speed;
    bool isMoving = false;
    public DynamicJoystick dk;
    public Rigidbody rb;
    public GameManager gameManager;



    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frames
    void Update()
    {
        
        
        if (isMoving)
        {
            return;
        }
        if (dk.Vertical == 1)
        {
           
           StartCoroutine(Roll(Vector3.forward));          
            Debug.Log("İleri Çalıştı");


        }
        else if (dk.Vertical == -1)
        {
            StartCoroutine(Roll(Vector3.back));
            Debug.Log("Geri Çalıştı");


        }

       else  if (dk.Horizontal==1)
        {
            StartCoroutine(Roll(Vector3.right));
            Debug.Log("Sağ Çalıştı");
        }  else if (dk.Horizontal == -1)
        {
            StartCoroutine(Roll(Vector3.left));
            Debug.Log("Sol Çalıştı");


        }
        


    }
    IEnumerator Roll(Vector3 direction)
       
    {
        isMoving = true;
        float remaingAngle = 90;
        Vector3 rotationCenter = transform.position + direction / 2 + Vector3.down / 2;
        Vector3 rotationAxis = Vector3.Cross(Vector3.up, direction);


        while (remaingAngle > 0) {
            float rotationAngle = Mathf.Min(Time.deltaTime * speed,remaingAngle);
            transform.RotateAround(rotationCenter, rotationAxis, rotationAngle);
            remaingAngle -= rotationAngle;
            yield return  null;

        }
        isMoving = false;


    }
}
