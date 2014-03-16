using UnityEngine;
using System.Collections;

/// <summary>
/// A response to a conversation that can trigger a series of actions.
/// </summary>
[System.Serializable]
public class Response {

	/// <summary>
	/// The response text.
	/// </summary>
	public string text = "response";

	/// <summary>
	/// Array of actions.
	/// </summary>
	public Action[] actions;

	/// <summary>
	/// Executes actions for this response.
	/// </summary>
	/// <param name="obj">The object executing the action.</param>
	public void execute(GameObject obj) {
		foreach (Action act in actions) {
			act.execute(obj);
		}
	}
}
