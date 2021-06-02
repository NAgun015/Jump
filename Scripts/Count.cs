using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    private float time;
    private float minuts;
    private float seconds;

    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimerFunc();
    }

    private void TimerFunc()
    {
        time += Time.deltaTime;
        minuts = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time % 60);
        if (seconds < 10)
        {
            gameObject.GetComponent<Text>().text = minuts.ToString()+":0"+seconds.ToString();
        }
        else
        {
            gameObject.GetComponent<Text>().text = minuts.ToString()+":"+seconds.ToString();
        }
    }
}
