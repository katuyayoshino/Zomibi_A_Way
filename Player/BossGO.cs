using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Boss G.
/// </summary>

public class BossGO : MonoBehaviour 
{

	void OnTriggerEnter (Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			Application.LoadLevel ("End");
		}
	}
}
