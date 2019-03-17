using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour {

    public Transform targetPos;
    public Transform relativeCenter;
    public float angularVelocity;

	void Update ()
    {
        RotateAround(relativeCenter.position, Vector3.right, angularVelocity);
	}

    void RotateAround(Vector3 rotationCenter, Vector3 direction, float speed)
    {
        this.targetPos.RotateAround(rotationCenter, direction, speed * Time.deltaTime);
        this.targetPos.LookAt(rotationCenter);
    }
}
