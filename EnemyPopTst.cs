using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Enemy pop tst.
/// </summary>

public class EnemyPopTst : MonoBehaviour 
{

	public Transform prefab;
	public Rigidbody projectile;


	void OnTriggerEnter(Collider other) 
	{
		Debug.Log("enemypop!!!");
		for (int i = 0; i < 1; i++) 
		{
			Instantiate(prefab, new Vector3(i * 2.0f, 0.5f, -48), Quaternion.identity);
		}
	}

}





