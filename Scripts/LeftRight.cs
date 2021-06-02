using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.0f, 4.0f), transform.position.y, transform.position.z);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
    }
}
