using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private GameObject Enemy;
    void Start()
    {
        Enemy = GameObject.FindWithTag("enemy");
    }

    void OnTriggerStay(Collider other) {
        Debug.Log("yeee");
        if (other.tag == "enemy")
        {
            Debug.Log("Des");
            Destroy(Enemy);
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Enemy.transform.position, speed);
    }
}
