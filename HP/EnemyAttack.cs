using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Enemy attack.
/// </summary>

public class EnemyAttack : MonoBehaviour 
{
	//エネミーの攻撃力
	public float attack = 10f;

	void OnTriggerEnter ( Collider col ) 
	{
		if(col.gameObject.tag == "Player")
		{
			//プレイヤーと衝突した時//攻撃する
			Attack(col.gameObject); 
		}
	}

	//攻撃する際に呼び出す
	public void Attack ( GameObject hit )
	{
		//相手の"Damage"関数を呼び出す
		hit.gameObject.SendMessage("Damage", attack);   
	}

}
