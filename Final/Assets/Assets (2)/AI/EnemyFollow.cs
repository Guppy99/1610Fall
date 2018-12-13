using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
	public float speed;
	public float stoppingDistance;

	public Transform target;
	public float ChaseRange;
	
	void Start ()
	{
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	
	void Update ()
	{

		if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
		{
			transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		}
	}
}