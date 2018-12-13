using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

	public Transform[] patrolPoints;
	public float speed;
	Transform currentPatrolPoint;
	public int currentPatrolIndex;

	void Start()
	{
		currentPatrolIndex = 0;
		currentPatrolPoint = patrolPoints[currentPatrolIndex];
	}

	void Update()
	{
		transform.Translate(Vector3.up * Time.deltaTime * speed);

		if (Vector3.Distance(transform.position, currentPatrolPoint.position) < .1f)
		{
			if (currentPatrolIndex + 1 < patrolPoints.Length)
			{
				currentPatrolIndex++;
			}
			else
			{
				currentPatrolIndex = 0;
			}

			currentPatrolPoint = patrolPoints[currentPatrolIndex];
		}

		Vector3 patrolPointDir = currentPatrolPoint.position - transform.position;
		float angle = Mathf.Atan2(patrolPointDir.y, patrolPointDir.x) * Mathf.Rad2Deg - 90f;
	}
}