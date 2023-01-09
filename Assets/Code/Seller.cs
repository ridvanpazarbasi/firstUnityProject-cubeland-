using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Seller : MonoBehaviour
{
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Material[] mat;
    public PlayerController p;
    public playerColltion pc;
    

    void Start()
    {
        


        
    }
    private void Update()
    {
        btn1.onClick.AddListener(buy1);
        btn2.onClick.AddListener(buy2);
        btn3.onClick.AddListener(buy3);
        btn4.onClick.AddListener(buy4);
        Debug.Log(PlayerPrefs.GetInt("money"));
    }

    public void buy1()
    {
        if (PlayerPrefs.GetInt("buy1") == 0) {
            if (PlayerPrefs.GetInt("money") >= 10)
            {
                p.colorChenge(mat[0]);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 10);
                pc.TextChance();


                PlayerPrefs.SetInt("buy1", 1);


            }
        }

        if (PlayerPrefs.GetInt("buy1") == 1)
        {
            p.colorChenge(mat[0]);

        }
        Debug.Log(PlayerPrefs.GetInt("money"));


    }
    public void buy2()
    {
        if (PlayerPrefs.GetInt("buy2") == 0) {

            if (PlayerPrefs.GetInt("money") >= 15)
            {

                p.colorChenge(mat[1]);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 15);
                pc.TextChance();

                PlayerPrefs.SetInt("buy2", 1);


            }
        }
        if (PlayerPrefs.GetInt("buy2") == 1)
        {
            p.colorChenge(mat[1]);

        }

        Debug.Log(PlayerPrefs.GetInt("money"));

    }
    public void buy3()
    {
        if (PlayerPrefs.GetInt("buy3") == 0)
        {
            if (PlayerPrefs.GetInt("money") >= 25)
            {
                p.colorChenge(mat[2]);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 20);
                pc.TextChance();

                PlayerPrefs.SetInt("buy3", 1);


            }
        }

        if (PlayerPrefs.GetInt("buy3") == 1)
        {
            p.colorChenge(mat[2]);

        }
        Debug.Log(PlayerPrefs.GetInt("money"));


    }
    public void buy4()
    {
        if (PlayerPrefs.GetInt("buy4") == 0)
        {

            if (PlayerPrefs.GetInt("money") >= 30)
            {

                p.colorChenge(mat[3]);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 25);
                pc.TextChance();

                PlayerPrefs.SetInt("buy4", 1);


            }
        }
        if (PlayerPrefs.GetInt("buy4") == 1)
        {
            p.colorChenge(mat[3]);

        }

        Debug.Log(PlayerPrefs.GetInt("money"));


    }

}
