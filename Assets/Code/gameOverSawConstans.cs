using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverSawConstans : MonoBehaviour
{

    public float moveSpeed = 1.0f;
    public Vector3 moveVector;
    GameManager gameManager;


    void Start()
    {

        GameObject gameController = GameObject.FindGameObjectWithTag("gameOver");
    }

    void Update()
    {
        transform.Rotate(moveVector * moveSpeed * Time.deltaTime);
        
    }
}
//Translate (gameManager.moveVector * gameManager.moveSpeed * Time.deltaTime);