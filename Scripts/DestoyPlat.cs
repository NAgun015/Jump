using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyPlat : MonoBehaviour
{
    public GameObject StaticObj;
    public GameObject newPlat;


    public void destroy(GameObject Plat)
    {
        Destroy(Plat);
        Instantiate(newPlat, new Vector3(0, 0, 20), Quaternion.identity);
        StaticObj.GetComponent<Static>().Count += 1;
    }
}
