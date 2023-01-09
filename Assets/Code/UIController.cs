using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button btn;
    public GameObject panel1;
    private void Start()
    {
        btn.onClick.AddListener(close);
    }

    public void close()
    {
        panel1.gameObject.SetActive(false);


    }
}
