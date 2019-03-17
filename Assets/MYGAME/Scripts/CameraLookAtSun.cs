using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtSun : MonoBehaviour {

    public Transform sun;
	
	void FixedUpdate ()
    {
        transform.LookAt(new Vector3(sun.position.x, 0f, sun.position.z));
	}
}
