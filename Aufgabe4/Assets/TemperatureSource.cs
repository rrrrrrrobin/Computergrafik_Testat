using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureSource : MonoBehaviour {

    public GameObject Teapot;
    public GameObject Tree;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();   // get all objects in scene

        foreach (var obj in allObjects)
        {
            Vector4 tempPosition = new Vector4(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z, 1);
            obj.GetComponent<MeshRenderer>().material.SetVector("_TemperaturePosition", tempPosition);
        }
    }
}