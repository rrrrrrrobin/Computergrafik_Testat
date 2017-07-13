using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour {
    public Material material;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;   //get camera depth
	}
	
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }

	// Update is called once per frame
	void Update () {
		
	}
}