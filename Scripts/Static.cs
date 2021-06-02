using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{
    public int HP;
    public int Count;
    public int Coin;
    public int Bullets;
    public float speed;

    void Start()
    {
        Count = 0;
    }

    void Update()
    {
        if (Count == 2)
        {
            speed += 0.2f;
            Count = 0;
        }
    }
}
