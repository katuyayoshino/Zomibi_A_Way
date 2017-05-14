using UnityEngine;
using System.Collections;

/// <summary>
/// 宮澤担当
/// Playerscript back.
/// </summary>

public class PlayerscriptBack : MonoBehaviour 
{

	public float Player_spd = 10.0f; //初期速度
	public float Button_spd = 2.0f; //ボタンを押しているときに速度倍率
	private float DashInterval = 3.0f;
	private float lastDashTime;

	public float JumpPower = 3.0f;//ジャンプの高さ

	void Start () 
	{
	}
	void Update () {
		// ひたすら前に進む（P181）
		//this.transform.Translate (new Vector3 (0.0f, 0.0f, Player_spd * Time.deltaTime));
	}

	public void PopUp(){//GUIbutton
		//ボタンをタップしたらPlayer_spd *= Button_spdを実行
		Player_spd *= Button_spd;
		//タップした１秒後に以下の処理実行
		Invoke ("Speed", -1.0f);
	}

	void Speed(){
		//速度を半分にする
		//Player_spd /= 2;
	}
	public void Jump(){

	}
}