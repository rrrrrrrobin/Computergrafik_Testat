using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("0"))
            print("0: Original");

        if (Input.GetKeyDown("1"))
            print("1: Graustufenkamera");

        if (Input.GetKeyDown("2"))
            print("2: Tiefenkamera");

        if (Input.GetKeyDown("3"))
            print("3: Wärmebildkamera");
    }
}
