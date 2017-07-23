using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureSource : MonoBehaviour {

    public GameObject Teapot; // Source of the temperatur

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Teapot != null)
        {
            Vector4 tempPosition = new Vector4(Teapot.transform.position.x, Teapot.transform.position.y, Teapot.transform.position.z, 1);
            this.GetComponent<MeshRenderer>().material.SetFloat("_TemperatureEnergy", Teapot.GetComponent<Temperature>().totalEnergy);
            this.GetComponent<MeshRenderer>().material.SetVector("_TemperaturePosition", tempPosition);
            this.GetComponent<MeshRenderer>().material.SetFloat("_Absorbtion", absorb);
        }
    }
}