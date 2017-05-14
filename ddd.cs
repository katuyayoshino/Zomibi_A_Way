using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Ddd.
/// </summary>

public class ddd : MonoBehaviour 
{

	void OnTriggerEnter (Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			Application.LoadLevel ("End");
		}
	}

}
