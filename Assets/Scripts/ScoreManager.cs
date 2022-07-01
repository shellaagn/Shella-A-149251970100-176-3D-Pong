using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // count score
    public int scoreP1, scoreP2, scoreP3, scoreP4;
    public int maxScore = 15;
    public int defeatedPlayer;

    // control paddle
    public BallController ball;
    public PlayerController paddleP1, paddleP2, paddleP3, paddleP4;

    // player status
    private bool aliveP1 = true, aliveP2 = true, aliveP3 = true, aliveP4 = true;
    public GameObject goalP1, goalP2, goalP3, goalP4;

    // game over
    public Text gameover, gameoverP1, gameoverP2, gameoverP3, gameoverP4;
    public GameObject replayButton, mainmenuButton;

    void Start()
    {
        Time.timeScale = 1;
        gameover.enabled = false;
        gameoverP1.enabled = false;
        gameoverP2.enabled = false;
        gameoverP3.enabled = false;
        gameoverP4.enabled = false;
        replayButton.SetActive(false);
        mainmenuButton.SetActive(false);
    }
    
    // add score
    public void AddScoreP1(int increment)
    {
        scoreP1 += increment;

        if(scoreP1 == maxScore)
        {
            defeatP1();
            paddleP1.playerDefeat();
        }
    }

    public void AddScoreP2(int increment)
    {
        scoreP2 += increment;

        if(scoreP2 == maxScore)
        {
            defeatP2();
            paddleP2.playerDefeat();
        }
    }

    public void AddScoreP3(int increment)
    {
        scoreP3 += increment;

        if(scoreP3 == maxScore)
        {
            defeatP3();
            paddleP3.playerDefeat();
        }
    }

    public void AddScoreP4(int increment)
    {
        scoreP4 += increment;

        if(scoreP4 == maxScore)
        {
            defeatP4();
            paddleP4.playerDefeat();
        }
    }

    ///////////////////////////////////////////////

    // defeat. turns paddle into wall 
    public void defeatP1()
    {
        aliveP1 = false;
        defeatedPlayer += 1;
        Debug.Log("P1 OUT");

        goalP1.GetComponent<MeshRenderer>().enabled = true;
        goalP1.GetComponent<Collider>().isTrigger = false;
    }

    public void defeatP2()
    {
        aliveP2 = false;
        defeatedPlayer += 1;
        Debug.Log("P2 OUT");

        goalP2.GetComponent<MeshRenderer>().enabled = true;
        goalP2.GetComponent<Collider>().isTrigger = false;
    }

    public void defeatP3()
    {
        aliveP3 = false;
        defeatedPlayer += 1;
        Debug.Log("P3 OUT");

        goalP3.GetComponent<MeshRenderer>().enabled = true;
        goalP3.GetComponent<Collider>().isTrigger = false;
    }

    public void defeatP4()
    {
        aliveP4 = false;
        defeatedPlayer += 1;
        Debug.Log("P4 OUT");

        goalP4.GetComponent<MeshRenderer>().enabled = true;
        goalP4.GetComponent<Collider>().isTrigger = false;
    }

    ///////////////////////////////////////////////

    void Update()
    {
        // check if 3 players have been defeated
        if (defeatedPlayer == 3)
        {
            GameOverDisplay();
        }
    }

    public void GameOverDisplay()
    {
        Time.timeScale = 0;

        gameover.enabled = true;
        replayButton.SetActive(true);
        mainmenuButton.SetActive(true);

        if (aliveP1 == true)
        {
            Debug.Log("Winner: P1!!");
            gameoverP1.enabled = true;
        }

        if (aliveP2 == true)
        {
            Debug.Log("Winner: P2!!");
            gameoverP2.enabled = true;
        }

        if (aliveP3 == true)
        {
            Debug.Log("Winner: P3!!");
            gameoverP3.enabled = true;
        }

        if (aliveP4 == true)
        {
            Debug.Log("Winner: P4!!");
            gameoverP4.enabled = true;
        }
    }
}
