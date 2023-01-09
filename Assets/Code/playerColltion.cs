using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerColltion : MonoBehaviour
{
    public cubeMove cube;
    public float pause;
    public Text moneyText;
    public PlayerController p;

    private void Start()
    {
        moneyText.text= PlayerPrefs.GetInt("money").ToString();
    }



    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "door")
        {
            if (cube != null) {
                cube.MoveStart();
            }

            
        }
        if (other.gameObject.tag == "enemy")
        {
            Debug.Log("enemy");
            StartCoroutine(GameOver());

            if (PlayerPrefs.GetInt("money") > 0)
            {
                
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 5);


                if (PlayerPrefs.GetInt("money") < 0) {


                    PlayerPrefs.SetInt("money", 0);
                }


            }
            Debug.Log(PlayerPrefs.GetInt("money"));
            moneyText.text = PlayerPrefs.GetInt("money").ToString();

        }




        if (other.gameObject.tag == "next")
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 10);
            moneyText.text = PlayerPrefs.GetInt("money").ToString();

            p.stopwork();
            StartCoroutine(NextLevel());
        }


    }




    public IEnumerator NextLevel()
    {

        yield return new WaitForSeconds(1);
        PlayerPrefs.SetInt("levelNo", PlayerPrefs.GetInt("levelNo") + 1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);




    }
    public IEnumerator GameOver()
    {

        yield return new WaitForSeconds(pause);

        FindObjectOfType<GameManager>().EndGame();




    }
    public void TextChance()
    {
        moneyText.text = PlayerPrefs.GetInt("money").ToString();



    }
}
