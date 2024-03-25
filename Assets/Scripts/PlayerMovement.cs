using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[Header("Movement Parameters")]
	public float moveSpeed = 5f;
	public float jumpForce = 5f;
	public int extraJumpsValue = 1;

	[Header("Ground Check Parameters")]
	public Transform groundCheck;
	public float groundCheckRadius = 0.2f;
	public LayerMask whatIsGround;

	private Rigidbody2D rb;
	private SpriteRenderer spriteRenderer;
	private Animator animatorComponent;
	private int extraJumps;
	private bool isGrounded;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		animatorComponent = GetComponent<Animator>();
	}

	private void Update()
	{
		CheckGrounded();
		Move();
		Jump();
	}

	private void CheckGrounded()
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

	void Move()
	{
		float moveX = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

		if (moveX != 0)
		{
			spriteRenderer.flipX = moveX < 0;
			animatorComponent.SetBool("IsRun", true);
		}
		else if (isGrounded)
		{
			rb.velocity = new Vector2(0, rb.velocity.y);
			animatorComponent.SetBool("IsRun", false);
		}
	}

	void Jump()
	{
		if (isGrounded)
		{
			extraJumps = extraJumpsValue;
		}

		if (Input.GetButtonDown("Jump") && (isGrounded || extraJumps > 0))
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpForce);
			if (!isGrounded)
			{
				extraJumps--;
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
	}
}
