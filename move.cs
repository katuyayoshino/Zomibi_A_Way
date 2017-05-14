using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Move.
/// </summary>

public class move : MonoBehaviour {
	public float thrust;
	public Rigidbody rb;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}
	void Update () 
	{
	}

	void FixedUpdate() 
	{
		rb.AddForce(transform.forward * thrust);
	}
}