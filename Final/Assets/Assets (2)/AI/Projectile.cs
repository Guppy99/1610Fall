using UnityEngine;

public class Projectile : MonoBehaviour
{

	public float speed;

	private Transform player;
	private Vector2 target;

	// Use this for initialization
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;

		target = new Vector2(player.position.x, player.position.y);
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}
}
