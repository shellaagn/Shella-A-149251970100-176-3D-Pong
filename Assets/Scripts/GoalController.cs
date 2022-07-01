using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;
    public bool player1, player2, player3, player4;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision == ball)
        {
            if(player1)
            {
                manager.AddScoreP1(1);
            }

            if(player2)
            {
                manager.AddScoreP2(1);
            }

            if(player3)
            {
                manager.AddScoreP3(1);
            }

            if(player4)
            {
                manager.AddScoreP4(1);
            }
        }
    }
}
