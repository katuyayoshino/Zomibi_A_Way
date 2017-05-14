using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Player back.
/// </summary>

public class PlayerBack : MonoBehaviour 
{
	//プログラム発火用
	void Update () 
	{
		this.transform.position += new Vector3 (0, 0, -0.1f);
	}
}
