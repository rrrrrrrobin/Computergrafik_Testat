using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class ChangeCam : MonoBehaviour
{
    public Material GrayscaleMaterial;
    public Material DepthMaterial;
    public Material ThermalMaterial;
    public Material fiber;
    public Material fiber_bump;

    public GameObject plane;
    public GameObject cylinder1;
    public GameObject cylinder2;
    public GameObject cylinder3;


    void Update()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();   // get all objects in scene

        if (Input.GetKeyDown(KeyCode.Alpha0))   // press "0" for normal mode
        {
            plane = GameObject.Find("Plane");
            plane.GetComponent<Renderer>().sharedMaterial = fiber;

            cylinder1 = GameObject.Find("Cylinder (1)");
            cylinder1.GetComponent<Renderer>().sharedMaterial = fiber_bump;

            cylinder2 = GameObject.Find("Cylinder (2)");
            cylinder2.GetComponent<Renderer>().sharedMaterial = fiber_bump;

            cylinder3 = GameObject.Find("Cylinder (3)");
            cylinder3.GetComponent<Renderer>().sharedMaterial = fiber_bump;

        }

        if (Input.GetKeyDown(KeyCode.Alpha1))   // press "1" for grayscale shader
        {
            foreach (var obj in allObjects)
            {
                obj.GetComponent<Renderer>().sharedMaterial = GrayscaleMaterial;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))   // press "2" for depth shader
        {
            foreach (var obj in allObjects)
            {
                obj.GetComponent<Renderer>().sharedMaterial = DepthMaterial;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))   // press "3" for thermal shader
        {
            foreach (var obj in allObjects)
            {
                obj.GetComponent<Renderer>().sharedMaterial = ThermalMaterial;
            }
        }
    }
}