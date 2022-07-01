using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    // ball Spawn
    public int maxSpawnedBall;
    public int spawnInterval;

    public GameObject ball;
    private List<GameObject> spawnedBallList;

    private Vector3 spawnedBallSpeed;
    private Vector3 spawnedBallPosition;
    private int ballSpawner;
    private Vector3 scaleChange = new Vector3(0.5f, 0.5f, 0.5f);

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        spawnedBallList = new List<GameObject>();
        timer = 0;
        RandomizeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer > spawnInterval)
        {
            RandomizeSpawn();
            timer -= spawnInterval;
        }
    }

    public void RandomizeSpawn()
    {
        ballSpawner = Random.Range(1,5);
        Debug.Log("Spawner: "+ ballSpawner);
        Debug.Log("Ball Count: "+ spawnedBallList.Count);

        if (spawnedBallList.Count >= maxSpawnedBall)
        {
            return;            
        }

        if (ballSpawner == 1)
        {
            spawnedBallPosition = new Vector3(-12,1,-12);
            spawnedBallSpeed = new Vector3(-9,0,-9);
            SpawnBall(spawnedBallPosition, spawnedBallSpeed);
        }

        if (ballSpawner == 2)
        {
            spawnedBallPosition = new Vector3(12,1,-12);
            spawnedBallSpeed = new Vector3(9,0,-9);
            SpawnBall(spawnedBallPosition, spawnedBallSpeed);
        }

        if (ballSpawner == 3)
        {
            spawnedBallPosition = new Vector3(12,1,12);
            spawnedBallSpeed = new Vector3(9,0,9);
            SpawnBall(spawnedBallPosition, spawnedBallSpeed);
        }

        if (ballSpawner == 4)
        {
            spawnedBallPosition = new Vector3(-12,1,12);
            spawnedBallSpeed = new Vector3(-9,0,9);
            SpawnBall(spawnedBallPosition, spawnedBallSpeed);
        }
    }

    private void SpawnBall(Vector3 spawnedBallSpeed, Vector3 spawnedBallPosition)
    {
        GameObject spawnedBall = Instantiate(ball, new Vector3(spawnedBallPosition.x, spawnedBallPosition.y, spawnedBallPosition.z), Quaternion.identity);
        spawnedBall.GetComponent<BallController>().speed = spawnedBallSpeed;
        spawnedBall.transform.localScale += scaleChange;
        
        spawnedBall.SetActive(true);
        spawnedBallList.Add(spawnedBall);
    }

    public void DeleteSpawnedBall(GameObject spawnedBall)
    {
        spawnedBallList.Remove(spawnedBall);
        Destroy(spawnedBall);
    }
}
