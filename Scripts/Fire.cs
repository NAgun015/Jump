using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    private GameObject Enemy;

    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Enemy = GameObject.FindWithTag("enemy");
                if (Enemy != null)
                {
                    Instantiate(Bullet, transform.position, Quaternion.identity);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
            {
                Enemy = GameObject.FindWithTag("enemy");
                if (Enemy != null)
                {
                    Instantiate(Bullet, transform.position, Quaternion.identity);
                }
            }
    }
}
