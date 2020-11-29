﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnSpawn : MonoBehaviour
{

	public GameObject enemyPrefab;

	float spawnDistance = 6f;

	float enemyRate = 3;
	float nextEnemy = 3;

	// Update is called once per frame
	void Update()
	{
		nextEnemy -= Time.deltaTime;

		if (nextEnemy <= 0)
		{
			nextEnemy = enemyRate;
			enemyRate *= 0.9f;
			if (enemyRate < 2)
				enemyRate = 2;

			Vector3 offset = Random.onUnitSphere;

			offset.z = 0;

			offset = offset.normalized * spawnDistance;

			Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
		}
	}
}
