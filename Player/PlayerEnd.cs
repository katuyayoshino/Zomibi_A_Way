using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野担当
/// Player end.
/// </summary>

public class PlayerEnd : MonoBehaviour 
{
	void OnTriggerEnter (Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			//true//false
			GameObject.Find("Player").GetComponent<PlayerBack>().enabled = false;
		}
	}
}
