using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force;
    public bool flag;
    private bool damage = false;


    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "plat")
        {
            flag = true;
        }
        if (other.tag == "enemy" || other.tag == "damage")
        {
            damage = true;
        }
    }

    void OnTriggerExit(Collider other) 
    {
        if (other.tag == "plat")
        {
            flag = false;
        }
    }

    void FixedUpdate() 
    {
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 0.6f, 1000.0f), transform.position.z);
        if ((transform.position.y == 0.6f && !flag) || damage)
        {
            Time.timeScale = 0;
        }
    }
    
    public void jumping()
    {
            transform.position = Vector3.Lerp(transform.position, transform.position + transform.up * force * Time.deltaTime, force);
            force /= 1.0015f;
    }

    public void falling()
    {
            transform.position = Vector3.Lerp(transform.position, transform.position - transform.up * force * Time.deltaTime, force);
            force *= 1.0015f;
    }
}