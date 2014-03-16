using UnityEngine;
using System.Collections;

/// <summary>
/// Controller to move player's rigidbody with keyboard input.
/// </summary>
public class PlayerRigidbodyController : MonoBehaviour {

	/// <summary>
	/// The speed.
	/// </summary>
	public float speed = 1.0f;

	/// <summary>
	/// Down key.
	/// </summary>
	public string downKey = "down";

	/// <summary>
	/// Up key.
	/// </summary>
	public string upKey = "up";

	/// <summary>
	/// The left key.
	/// </summary>
	public string leftKey = "left";

	/// <summary>
	/// The right key.
	/// </summary>
	public string rightKey = "right";

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(downKey)) {
			rigidbody2D.AddForce(new Vector2(0, -1) * speed);
		}

		if (Input.GetKey(upKey)) {
			rigidbody2D.AddForce(new Vector2(0, 1) * speed);
		}

		if (Input.GetKey(leftKey)) {
			rigidbody2D.AddForce(new Vector2(-1, 0) * speed);
		}

		if (Input.GetKey(rightKey)) {
			rigidbody2D.AddForce(new Vector2(1, 0) * speed);
		}
	}
}
