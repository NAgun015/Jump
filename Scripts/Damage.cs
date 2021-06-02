using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject D1;
    public GameObject D2;
    private float count = 0;

    void Update()
    {
        if (count < 1)
        {
            count += Time.deltaTime;
        }
        else
        {
            count = 0;
            if (D1.transform.position.y == 0.3f)
            {
                D1.transform.localPosition = new Vector3(0.5f, -0.5f, 0);
                D2.transform.localPosition = new Vector3(-0.5f, 0.3f, 0);
            }
            else
            {
                D1.transform.localPosition = new Vector3(0.5f, 0.3f, 0);
                D2.transform.localPosition = new Vector3(-0.5f, -0.5f, 0);
            }
        }
    }
}
