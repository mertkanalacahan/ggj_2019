using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text timer;
    public float timeLeft = 100;
    // Start is called before the first frame update
    void Start()
    {
        timer.text = "Time Left: " + timeLeft.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timer.text = "Time Left: " + ((int)timeLeft).ToString();

        if (timeLeft < 0)
        {
            //
        }
    }
}
