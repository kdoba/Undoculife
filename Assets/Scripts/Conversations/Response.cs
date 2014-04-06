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
	public BaseAction[] actions;

	/// <summary>
	/// Executes actions for this response.
	/// </summary>
	/// <param name="obj">The object executing the action.</param>
	public void Execute(GameObject obj) {
		foreach (BaseAction act in actions) {
			act.Execute(obj);
		}
	}
}
