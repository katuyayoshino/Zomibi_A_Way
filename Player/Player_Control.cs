using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Player_ control.
/// </summary>

public class Player_Control : MonoBehaviour 
{
	//現在のスピード
	public float current_speed =0.0f;
	//
	public static float NARAKU_HEIGHT = -5.0f;
	//加速度
	public static float ACCELERATION = 0.0f;
	//速度の最小値
	public static float SPEED_MIN = 4.0f;
	//速度の最大値
	public static float SPEED_MAX = 8.0f;
	//Playerの各種状態を表すデータ型
	public enum STEP
	{
		//状態情報なし
		NONE = -1,
		//走る
		RUN = 0,
		// 
		TOUCH_ENEMY,
	};

	//Playerの現在の状態
	public STEP step = STEP.NONE;
	//Playerの次の状態
	public STEP next_step = STEP.NONE;

	//経過時間
	public float step_timer = 0.0f;

	//何とぶつかっているかどうか
	private bool is_collided = false;

	private void check_landed()
	{
		do {
			//Playerの現在の位置
			Vector3 s = this.transform.position;
			//sから下に1.0fに移動した位置
			Vector3 e = s + Vector3.down * 1.0f;
			RaycastHit hit;
			if (!Physics.Linecast (s, e, out hit)) { //sからeの間に何もしない場合
				//何もせずdo~whileループを抜ける(脱出口へ)
				break;
			}
		} while(false);
		//ループの脱出口
	}

	void Start () 
	{
		this.next_step = STEP.RUN;
	}

	void Update () 
	{
		this.transform.Translate (new Vector3 (0.0f, 0.0f, 3.0f * Time.deltaTime));
		//速度の設定
		Vector3 velocity = this.GetComponent<Rigidbody>().velocity;
		//着地状態かどうかをチェック
		this.check_landed ();
		switch (this.step) 
		{
		case STEP.RUN:
			break;
		}
		//経過時間を進める
		this.step_timer += Time.deltaTime;
		//「次の状態」が「状態情報なし」以外の間
		while (this.next_step != STEP.NONE) 
		{
			//「現在の状態」を「次の状態」に変更
			this.step = this.next_step;
			//「次の状態」を「状態なし」に変更
			this.next_step = STEP.NONE;
			//状態が変化したので、経過時間をゼロにリセット
			this.step_timer = 0.0f;
		}
		//状態ごとの、毎フレームの更新処理
		switch (this.step) 
		{
		//走行中の場合
		case STEP.RUN:
			//速度をあげる
			velocity.x += Player_Control.ACCELERATION * Time.deltaTime;
			//計算で求めたスピードが、設定すべきスピードを超えていたら
			if (Mathf.Abs (velocity.x) > this.current_speed) 
			{
				//超えないように調整する
				velocity.x *= this.current_speed / Mathf.Abs (velocity.x);
			}
			break;
		}
		//Rigidbodyの速度を、上記で求めた速度で更新
		//この行は、状態にかかわらず毎回実行される
		this.GetComponent<Rigidbody>().velocity = velocity;
	}

	//HPのプログラムをここに書く
	public void		onTouchEnemy(EnemyControl enemy)
	{
		do{

			if(this.step == STEP.TOUCH_ENEMY) break;

			this.next_step = STEP.TOUCH_ENEMY;

			Debug.Log("miss");

		}while(false);
	}

}












