using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTest : MonoBehaviour
{
	public Transform target;
	public float radius = 3f;

	// Update is called once per frame
	void Update ()
	{
		var pos = target.position;
		var quat = Quaternion.AngleAxis (pos.x / (radius * 2f * Mathf.PI) * 360f, Vector3.back);
		transform.position = quat * new Vector3 (0f, pos.y + radius, 0f);
		transform.rotation = quat;
	}
}
