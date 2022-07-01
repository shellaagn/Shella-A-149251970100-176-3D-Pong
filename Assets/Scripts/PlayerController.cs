using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    private Rigidbody rig;

    public bool player1, player2, player3, player4;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            // move up
            return Vector3.forward * speed;
        }

        if (Input.GetKey(downKey))
        {
            // move down
            return Vector3.back * speed;
        }

        if (Input.GetKey(leftKey))
        {
            // move left
            return Vector3.left * speed;
        }

        if (Input.GetKey(rightKey))
        {
            // move right
            return Vector3.right * speed;
        }

        // reset speed
        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        // move object
        rig.velocity = movement;
    }

    public void playerDefeat()
    {
        // delete paddle
        if (player1)
        {
            gameObject.SetActive(false);
        }

        if (player2)
        {
            gameObject.SetActive(false);
        }

        if (player3)
        {
            gameObject.SetActive(false);
        }

        if (player4)
        {
            gameObject.SetActive(false);
        }
    }
}
