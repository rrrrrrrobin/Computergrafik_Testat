using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour {

    static float bolzm = 5.67f * Mathf.Pow(10, -8); // bolzmann formula from given exercise
    float temp;
    float energy;
    float radius;
    float volume;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        volume = (4 / 3) * Mathf.PI * radius;  // volume of sphere
        energy = volume * Mathf.Pow(temp, 4) * bolzm;  // energy formula from given exercise
    }
}
