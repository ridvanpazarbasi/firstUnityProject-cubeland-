using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startYukle : MonoBehaviour
{
   
    

    void Start()
    {

        if (PlayerPrefs.HasKey("levelNo") == false)
        {
            PlayerPrefs.SetInt("levelNo", 1);
        }

        SceneManager.LoadScene(PlayerPrefs.GetInt("levelNo"));


    }


}
