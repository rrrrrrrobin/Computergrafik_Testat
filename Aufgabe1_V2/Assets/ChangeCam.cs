using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class ChangeCam : MonoBehaviour
{
    public Material GrayscaleMaterial;
    public Material DepthMaterial;
    public Material ThermalMaterial;
    public Material Red;


    void Update()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();   // get all objects in scene

        if (Input.GetKeyDown(KeyCode.Alpha0))   // press "0" for normal mode
        {
            foreach (var obj in allObjects)
            {
                obj.GetComponent<Renderer>().sharedMaterial = Red;
            }
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