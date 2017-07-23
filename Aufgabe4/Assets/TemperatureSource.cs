using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureSource : MonoBehaviour {

    public GameObject Sphere; // Source of the temperatur

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Sphere != null)
        {
            Vector4 tempPosition = new Vector4(Sphere.transform.position.x, Sphere.transform.position.y, Sphere.transform.position.z, 1);
            this.GetComponent<MeshRenderer>().material.SetFloat("_TemperatureEnergy", Sphere.GetComponent<Temperature>().energy);
            this.GetComponent<MeshRenderer>().material.SetVector("_TemperaturePosition", tempPosition);
            this.GetComponent<MeshRenderer>().material.SetFloat("_Absorbtion", absorb);
        }
    }
}