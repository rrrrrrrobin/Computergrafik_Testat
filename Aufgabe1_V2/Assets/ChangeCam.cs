using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeCam : MonoBehaviour
{
    public GameObject Camera;
    public GameObject GrayscaleCamera;
    public GameObject DepthCamera;
    public GameObject ThermalCamera;

    void Start()
    {
        Camera.SetActive(true);
        GrayscaleCamera.SetActive(false);
        DepthCamera.SetActive(false);
        ThermalCamera.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey("0"))
            Camera.SetActive(true);
            GrayscaleCamera.SetActive(false);
            DepthCamera.SetActive(false);
            ThermalCamera.SetActive(false);

        if (Input.GetKey("1"))
            Camera.SetActive(false);
            GrayscaleCamera.SetActive(true);
            DepthCamera.SetActive(false);
            ThermalCamera.SetActive(false);

        if (Input.GetKey("2"))
            Camera.SetActive(false);
            GrayscaleCamera.SetActive(false);
            DepthCamera.SetActive(true);
            ThermalCamera.SetActive(false);

        if (Input.GetKey("3"))
            Camera.SetActive(false);
            GrayscaleCamera.SetActive(false);
            DepthCamera.SetActive(false);
            ThermalCamera.SetActive(true);
    }
}
