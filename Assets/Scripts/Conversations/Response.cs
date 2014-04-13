using UnityEngine;
using System.Collections;

/// <summary>
/// A response to a conversation that can trigger a series of actions.
/// </summary>
[System.Serializable]
public class Response {

	/// <summary>
	/// The response text that the player says.
	/// </summary>
	public string text = "response";

	/// <summary>
	/// The optional reply that the npc gives.
	/// </summary>
	public string reply = null;

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
