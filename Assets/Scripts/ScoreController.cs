using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoretextP1, scoretextP2, scoretextP3, scoretextP4;
    public ScoreManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretextP1.text = manager.scoreP1.ToString();
        scoretextP2.text = manager.scoreP2.ToString();
        scoretextP3.text = manager.scoreP3.ToString();
        scoretextP4.text = manager.scoreP4.ToString();
    }
}
