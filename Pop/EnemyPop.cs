using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 吉野勝也担当s
/// Enemy pop.
/// </summary>

public class EnemyPop : MonoBehaviour 
{
	public GameObject EnemyPrefab = null; // Prefab「Enemy」を保持.
	public static float RESPAWN_TIME_ENEMY = 0.5f; // 出現時間定数.
	private float respawn_timer_enemy = 0.0f; // 出現時間.

	public void respawnIron()
	{
		// エネミープレハブをインスタンス化.
		GameObject go = GameObject.Instantiate(this.EnemyPrefab) as GameObject;
		// エネミーの出現ポイントを取得.タグ"EnemyRespawn"
		Vector3 pos = GameObject.Find("EnemyRespawn").transform.position;
		// 出現位置を調整.高さ
		pos.y = 1.1f;
		pos.x += Random.Range(-1.0f, 1.0f);
		pos.z += Random.Range(-1.0f, 1.0f);
		// エネミーの位置を移動.
		go.transform.position = pos;
	}

	void Start () 
	{
		// エネミーの出現ポイントを取得し、レンダラーを不可視に.
		GameObject enemyrespawn = GameObject.Find("EnemyRespawn");

		//enemyrespawn.GetComponent<MeshRenderer>().enabled = false;
	}

	void Update () 
	{
		respawn_timer_enemy += Time.deltaTime;
		if(respawn_timer_enemy > RESPAWN_TIME_ENEMY) 
		{
			respawn_timer_enemy = 0.0f;
			this.respawnIron(); // エネミーを出現させる.
		}
	}
}
