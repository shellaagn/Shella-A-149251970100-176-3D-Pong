using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rig;

    public Collider goal1, goal2, goal3, goal4;
    public SpawnController spawnManager;
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        // resetSpeed.x = speed.x;
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision == goal1)
        {
            scoreManager.AddScoreP1(1);
            spawnManager.DeleteSpawnedBall(gameObject);
        }

        if (collision == goal2)
        {
            scoreManager.AddScoreP2(1);
            spawnManager.DeleteSpawnedBall(gameObject);
        }

        if (collision == goal3)
        {
            scoreManager.AddScoreP3(1);
            spawnManager.DeleteSpawnedBall(gameObject);
        }

        if (collision == goal4)
        {
            scoreManager.AddScoreP4(1);
            spawnManager.DeleteSpawnedBall(gameObject);
        }
    }
}
