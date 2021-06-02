using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlats : MonoBehaviour
{
    public GameObject[] Plats;
    private int count;
    private int Type;
    private GameObject newObj1, newObj2, newObj3;
    private float xpos;

    void Start()
    {
        count = Random.Range(1, 3);
        for (int i = 0; i < count; i++)
        {
            //Type = TypeGen(i);
            Type = SmartRand(i);
            Inst(Type, i);
        }
    }

    private int SmartRand(int I)
    {
        int SR, K;

        if (I == 0)
        {
            SR = Random.Range(30,101);
        }
        else
        {
            SR = Random.Range(1,101);
        }

        if (SR <= 15) K = 0;
        else if (SR <= 30) K = 1;
        else if (SR <= 77) K = 2;
        else if (SR <= 97) K = 3;
        else K = 4;

        return(K);
    }

    private int TypeGen(int I)
    {
        int K;
        if (I == 0)
        {
            K = Random.Range(2, Plats.Length);
        }
        else
        {
            K = Random.Range(0, Plats.Length);
        }
        return(K);
    }

    private void Inst(int type, int I)
    {
        float L;
        float S1, S2;
        float R;
        if (I == 0)
        {
            newObj1 = Instantiate (Plats[type], new Vector3(Random.Range(-4.0f, 4.0f), 0, 0), Quaternion.identity) as GameObject;
            newObj1.transform.SetParent(gameObject.transform, false);
        }
        if (I == 1)
        {
            L = newObj1.transform.position.x - 2;
            R = newObj1.transform.position.x + 2;
            if ((-4.0f - L) <= 0 && (4.0f - R) >= 0)
            {
                if (Random.Range(1, 3) == 1)
                {
                    xpos = Random.Range(-4.0f, L);
                }
                else
                {
                    xpos = Random.Range(R, 4.0f);
                }
            }
            else if ((-4.0f - L) <= 0)
            {
                xpos = Random.Range(-4.0f, L);
            }
            else if ((4.0f - R) >= 0)
            {
                xpos = Random.Range(R, 4.0f);
            }
            newObj2 = Instantiate (Plats[type], new Vector3(xpos, 0, 0), Quaternion.identity) as GameObject;
            newObj2.transform.SetParent(gameObject.transform, false);
        }
        if (I == 2)
        {
            if (newObj1.transform.position.x > newObj2.transform.position.x)
            {
                L = newObj2.transform.position.x - 2;
                R = newObj1.transform.position.x + 2;
                S1 = newObj2.transform.position.x + 2;
                S2 = newObj1.transform.position.x - 2;
            }
            else
            {
                L = newObj1.transform.position.x - 2;
                R = newObj2.transform.position.x + 2;
                S1 = newObj1.transform.position.x + 2;
                S2 = newObj2.transform.position.x - 2;
            }

            if ((-4.0f - L) <= 0 && (4.0f - R) >= 0 && (S2 - S1) >= 0)
            {
                int ii = Random.Range(1, 4);
                if (ii == 1)
                {
                    xpos = Random.Range(-4.0f, L);
                }
                else if (ii == 3)
                {
                    xpos = Random.Range(R, 4.0f);
                }
                else
                {
                    xpos = Random.Range(S1, S2);
                }
            }
            else if ((-4.0f - L) <= 0 && (4.0f - R) >= 0)
            {
                if (Random.Range(1, 3) == 1)
                {
                    xpos = Random.Range(-4.0f, L);
                }
                else
                {
                    xpos = Random.Range(R, 4.0f);
                }
            }
            else if ((-4.0f - L) <= 0 && (S2 - S1) >= 0)
            {
                if (Random.Range(1, 3) == 1)
                {
                    xpos = Random.Range(-4.0f, L);
                }
                else
                {
                    xpos = Random.Range(S1, S2);
                }
            }
            else if ((S2 - S1) >= 0 && (4.0f - R) >= 0)
            {
                if (Random.Range(1, 3) == 1)
                {
                    xpos = Random.Range(S1, S2);
                }
                else
                {
                    xpos = Random.Range(R, 4.0f);
                }
            }
            else if ((-4.0f - L) <= 0)
            {
                    xpos = Random.Range(-4.0f, L);
            }
            else if ((4.0f - R) >= 0)
            {
                    xpos = Random.Range(R, 4.0f);
            }
            else if ((S2 - S1) >= 0)
            {
                    xpos = Random.Range(S1, S2);
            }

            newObj3 = Instantiate (Plats[type], new Vector3(xpos, 0, 0), Quaternion.identity) as GameObject;
            newObj3.transform.SetParent(gameObject.transform, false);
        }
    }
}
