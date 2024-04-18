using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public GameObject pa;
	public float shrinkDuration = 0.5f;
	public float shrinkFactor = 0.9f;

	void Update()
	{
		if (!Input.GetKey("f")) return;
		Debug.Log("respects paid");
		Vector3 v = pa.transform.position;
		v += Vector3.up;

		RaycastHit hit;
		if (Physics.Raycast(v, pa.transform.forward, out hit, 5))
		{
			Debug.Log("raycast hit");
			if (!hit.collider.CompareTag("NPC")) return;
			hit.collider.gameObject.SendMessage("Talk");
		}

	}

	void OnDrawGizmosSelected()
	{
		Vector3 tmp = transform.position;
		tmp += transform.forward * 5;

		Gizmos.color = Color.red;
		Gizmos.DrawLine(transform.position, tmp);
	}

	public void Shrink()
	{
		transform.localScale *= shrinkFactor;
	}
}
