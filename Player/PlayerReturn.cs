using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野担当
/// Player return.
/// </summary>

public class PlayerReturn : MonoBehaviour 
{

	void OnTriggerEnter (Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			//true//false
			//
			GameObject.Find("Player").GetComponent<Playerscript>().enabled = false;
			GameObject.Find("Player").GetComponent<Player_Control>().enabled = false;
			GameObject.Find("Player").GetComponent<PlayerBack>().enabled = true;
			GameObject.Find("Player").GetComponent<PlayerscriptBack>().enabled = true;
			//
			GameObject.Find("ddd06").GetComponent<MeshRenderer>().enabled = false;
			//
			GameObject.Find("BOSS").GetComponent<Bossrig>().enabled = true;
		}
	}
}
