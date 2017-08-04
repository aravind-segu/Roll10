using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class GlowScript : MonoBehaviour {
    public Shader shader1;
	// Use this for initialization
	void Start () {
        shader1 = Shader.Find("NewSurfaceShader");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
