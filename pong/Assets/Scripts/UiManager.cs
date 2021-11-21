using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public Text counterText;
    public Text ComcounterText;
    public GameObject  GOver;
    public GameObject  Win;
    public bool endgame;

    //public int score;
    //public GameObject Win;

    private void Awake() 
    {
    }

    void Start()
    {
        endgame = false;
    }


    public void ScoreCount()
    {
        string[] newText = counterText.text.Split(':');
        int hold = int.Parse(newText[1]) -1;
        //score = hold;
        if (hold <= 0)
        {
            GameOverScene();
        }
        counterText.text = newText[0] + ": " + hold.ToString();
    }

    public void ComScoreCount()
    {
        string[] newText = ComcounterText.text.Split(':');
        int hold = int.Parse(newText[1]) -1;
        if (hold <= 0)
        {
            WiningScene();
        }
        ComcounterText.text = newText[0] + ": " + hold.ToString();
    }

    public void GameOverScene()
    {
        GOver.SetActive(true);
        FindObjectOfType<playerControl>().GetComponent<MonoBehaviour>().enabled = false;
        FindObjectOfType<enemy>().GetComponent<MonoBehaviour>().enabled = false;
        FindObjectOfType<Ball>().GetComponent<MonoBehaviour>().enabled = false;
        Destroy(FindObjectOfType<Ball>());
        endgame = true;
        //FindObjectOfType<Ball>().transform.position = FindObjectOfType<Ball>().startp;
        //FindObjectOfType<Ball>().RG.AddForce(new Vector3(0,0 , 0));
    }
    //restart
    public void Retry_Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WiningScene()
    {
        Win.SetActive(true);
        FindObjectOfType<playerControl>().GetComponent<MonoBehaviour>().enabled = false;
        FindObjectOfType<enemy>().GetComponent<MonoBehaviour>().enabled = false;
        FindObjectOfType<Ball>().GetComponent<MonoBehaviour>().enabled = false;
        Destroy(FindObjectOfType<Ball>());
        endgame = true;
        //FindObjectOfType<Ball>().transform.position = FindObjectOfType<Ball>().startp;
        //FindObjectOfType<Ball>().RG.AddForce(new Vector3(0,0 , 0));
    }
}
