using UnityEngine;
using System.Collections;

/// <summary>
/// A script to show a conversation dialog.
/// </summary>
public class Conversation : MonoBehaviour {

	/// <summary>
	/// If true, shows the dialog on collision.
	/// </summary>
	public bool showOnCollide = true;

	/// <summary>
	/// The header text for the dialog.
	/// </summary>
	public string headerText = "header";

	/// <summary>
	/// The response choices.
	/// </summary>
	public string[] responses;

	public 

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
