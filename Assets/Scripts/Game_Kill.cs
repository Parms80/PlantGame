using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Kill : MonoBehaviour
{

    public GameObject goTimer;

    private Text txtTimer;
    private float timer = 0;
    public int maxTime = 10;

    // Use this for initialization
    void Start()
    {
        txtTimer = goTimer.GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        int t = System.Convert.ToInt32(timer % 60);

        if (t <= maxTime)
        {
            txtTimer.text = "Time: " + (maxTime - t);
        }
        else
        {
            // gameOver
        }
    }
}
