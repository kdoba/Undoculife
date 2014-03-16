using UnityEngine;
using System.Collections;

/// <summary>
/// Controller to move player with keyboard input.
/// </summary>
public class PlayerController : MonoBehaviour {

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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(downKey)) {
			transform.Translate(0, -speed, 0);
		}

		if (Input.GetKey(upKey)) {
			transform.Translate(0, speed, 0);
		}

		if (Input.GetKey(leftKey)) {
			transform.Translate(-speed, 0, 0);
		}

		if (Input.GetKey(rightKey)) {
			transform.Translate(speed, 0, 0);
		}
	}
}
