using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    private GameObject Player;
    private GameObject StaticObj;
    //private bool flag = true;

    void Start()
    {
        Player = GameObject.Find("Player");
        StaticObj = GameObject.Find("Static");
    }

    void FixedUpdate()
    {
        speed = StaticObj.GetComponent<Static>().speed;
        if (gameObject.transform.position.z <= -10.0f)
        {
            Player.GetComponent<DestoyPlat>().destroy(gameObject);
            Player.GetComponent<Jump>().force = 6;
        }
        
        transform.position = Vector3.Lerp(transform.position, transform.position - transform.forward * speed * Time.deltaTime, speed);
        if (gameObject.transform.position.z <= 0.0f && gameObject.transform.position.z > -4.88f)
        {
            Player.GetComponent<Jump>().jumping();
        }
        else if (gameObject.transform.position.z <= -5.12f)
        {
            Player.GetComponent<Jump>().falling();
        }

        //gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - speed);
        // if (gameObject.transform.position.z <= 0 && flag)
        // {
        //     Player.GetComponent<Jump>().jumping();
        //     flag = false;
        // }
    }
}
