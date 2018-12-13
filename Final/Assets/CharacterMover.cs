using UnityEngine;
using UnityEngine.UI;


public class CharacterMover : MonoBehaviour
{

	private CharacterController Controller;

	public float Gravity = 9.81f;
	public float MoveSpeed = 9.0f;
	public float JumpSpeed = 9.0f;
	private float movement = 0f;
	private Vector2 position;
	private Vector2 rotation;
	private Rigidbody2D Rigidbody2D;

	public int curHealth;
	public int maxHealth = 100;

	// Use this for initialization
	void Start()
	{
		Rigidbody2D = GetComponent<Rigidbody2D>();
		Controller = GetComponent<CharacterController>();

		curHealth = maxHealth;
	}

	// Update is called once per frame
	void Update()
	{
		if(Controller.isGrounded)
		{
			position.Set(0, MoveSpeed * Input.GetAxis("Vertical"));
			position.Set(MoveSpeed * Input.GetAxis("Horizontal"), 0);
			transform.Rotate(rotation);
			position = transform.TransformDirection(position);

			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
		}

		if(movement > 0f)
			{
				Rigidbody2D.velocity = new Vector2(movement * JumpSpeed, Rigidbody2D.velocity.y);
				transform.localScale = new Vector2(-1f, 1f);
			}
			else if (movement < 0f)
			{
				Rigidbody2D.velocity = new Vector2(0, Rigidbody2D.velocity.y);
				transform.localScale = new Vector2(1f, 1f);
			}

			position.y -= Gravity * Time.deltaTime;
			Controller.Move(position * Time.deltaTime);
	
		
		if (curHealth > maxHealth)
		{
			curHealth = maxHealth;
		}
		if (curHealth <= 0)
		{
			Die();
		}
		
	}
	public void Damage(int dmg)
	{
		curHealth -= dmg;
	}
	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	}
