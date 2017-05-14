using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Respawn stop.
/// </summary>

public class RespawnStop : MonoBehaviour 
{

	void OnTriggerEnter (Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			//true//false
			GameObject.Find("EnemyRespawn").GetComponent<EnemyPop>().enabled = false;
		}
	}

}
