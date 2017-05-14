using UnityEngine;
using System.Collections;

/// <summary>
/// BOSS oke.
/// 吉野勝也担当
/// </summary>

public class BOSSOke : MonoBehaviour 
{

	void OnTriggerEnter (Collider col) 
	{
		if(col.gameObject.tag == "BOSS")
		{
			//BOSSとぶつかった時実行
			//true//false
			GameObject.Find("BOSS").GetComponent<Bossrig>().enabled = true;
		}
	}
}
