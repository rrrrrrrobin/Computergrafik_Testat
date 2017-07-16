using System.Collections;
using UnityEngine;

public class CamKeyChange : MonoBehaviour {

    [SerializeField]
    Camera camMain;
    [SerializeField]
    Camera camONE;
    [SerializeField]
    Camera camTWO;
    [SerializeField]
    Camera camTHREE;
    
	// Use this for initialization
	void Start () {

        camMain.GetComponent<Camera>().enabled = true;
        camONE.GetComponent<Camera>().enabled = false;
        camTWO.GetComponent<Camera>().enabled = false;
        camTHREE.GetComponent<Camera>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("0"))
        {
            camMain.GetComponent<Camera>().enabled = true;
            camONE.GetComponent<Camera>().enabled = false;
            camTWO.GetComponent<Camera>().enabled = false;
            camTHREE.GetComponent<Camera>().enabled = false;
        }
        if (Input.GetKeyDown("1"))
            {
            camMain.GetComponent<Camera>().enabled = false;
            camONE.GetComponent<Camera>().enabled = true;
            camTWO.GetComponent<Camera>().enabled = false;
            camTHREE.GetComponent<Camera>().enabled = false;
            }
        if (Input.GetKeyDown("2"))
        {
            camMain.GetComponent<Camera>().enabled = false;
            camONE.GetComponent<Camera>().enabled = false;
            camTWO.GetComponent<Camera>().enabled = true;
            camTHREE.GetComponent<Camera>().enabled = false;
        }
        if (Input.GetKeyDown("3"))
        {
            camMain.GetComponent<Camera>().enabled = false;
            camONE.GetComponent<Camera>().enabled = false;
            camTWO.GetComponent<Camera>().enabled = false;
            camTHREE.GetComponent<Camera>().enabled = true;
        }

    }
}
