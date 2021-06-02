using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] Enemys;

    void Start()
    {
        int K = Random.Range(0, 3);
        GameObject newEnemy = Instantiate (Enemys[K], new Vector3(0, 0.5f, 0), Quaternion.identity) as GameObject;
        newEnemy.transform.SetParent(gameObject.transform, false);
    }
}
