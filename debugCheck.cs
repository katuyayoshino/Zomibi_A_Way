using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// 吉野勝也担当
/// Debug check.
/// </summary>

public class debugCheck : MonoBehaviour {


	//	デバッグ用のUI取得
	public Text debugLog;
	
	//	傾きの保持
	private Vector3 accel;
	
	
	void Update () {
		accel = Input.acceleration;
		
		debugLog.text = "傾き\n" + "X:" + accel.x.ToString() + "\nY:" + accel.y.ToString() + "\nZ:" + accel.z.ToString();
		
	}
}
