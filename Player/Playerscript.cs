using UnityEngine;
using System.Collections;

/// <summary>
/// 宮澤担当
/// Playerscript.
/// </summary>

public class Playerscript : MonoBehaviour {

	public float Player_spd = 10.0f; //初期速度
	public float Button_spd = 2.0f; //ボタンを押しているときに速度倍率

	//押された回数を格納する変数
	/*private int counter = 0;
	const int counterMax = 4;//最大値*/

	private float DashInterval = 3.0f;
	private float lastDashTime;

	public float JumpPower = 3.0f;//ジャンプの高さ

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// ひたすら前に進む（P181）
		this.transform.Translate (new Vector3 (0.0f, 0.0f, Player_spd * Time.deltaTime));
		//Aキー(仮)が入力したらPlayer_spd *= Button_spdを実行
		/*if (Input.GetKeyDown(KeyCode.A)) {
			Player_spd *= Button_spd;
		}*/
	}
	
	 public void PopUp(){//GUIbutton
		//ボタンをタップしたらPlayer_spd *= Button_spdを実行
		Player_spd *= Button_spd;
		//タップした１秒後に以下の処理実行
		Invoke ("Speed", 1.0f);

		//Invoke ("Dash", 0.0f);

		/*counter++;
		if (counter <= counterMax) {
			Debug.Log ("Max");
		}*/
		}

	void Speed(){
		//速度を半分にする
		Player_spd /= 2;
	}

	/*private void Dash(){
		if (Time.time > lastDashTime + DashInterval) {
			lastDashTime = Time.time;
		}
	}*/

	public void Jump(){
	
	}
}