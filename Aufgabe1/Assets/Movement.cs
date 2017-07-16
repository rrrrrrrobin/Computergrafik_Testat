using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float mSpeed;

	// Use this for initialization
	void Start () {
        mSpeed = 7f;
	}
	
	// Update is called once per frame
	void Update () {
       transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
       
    }
}
