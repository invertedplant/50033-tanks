﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/EnemyStats")]
public class EnemyStats : ScriptableObject {

	public float moveSpeed = 1;
	public float lookRange = 40f;
	public float lookSphereCastRadius = 1f;

	public float attackRange = 1f;
	public float attackRate = 0.75f;
	public float attackForce = 15f;
	public int attackDamage = 50;
	public float chaseTime = 5f;

	public float searchDuration = 4f;
	public float searchingTurnSpeed = 120f;
}