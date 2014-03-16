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
	public Response[] responses;
	
	/// <summary>
	/// Updates GUI for this conversation when it is active.
	/// Returns index of the response chosen or -1 if none chosen yet.
	/// </summary>
	public int UpdateGUI() {
		float y = 0;
		int i = 0;
		foreach (Response response in responses) {
			if (GUI.Button(new Rect(0, y, 200, 20), response.text)) {
				return i;
			}
			y += 20;
			++i;
		}
		return -1;
	}
}
