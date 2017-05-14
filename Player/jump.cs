using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Jump.
/// </summary>

public class jump : MonoBehaviour 
{
	public float jumpPower = 5.0f;

	public void Jamp()
	{
		this.GetComponent<Rigidbody> ().velocity += Vector3.up * jumpPower;
	}
}
