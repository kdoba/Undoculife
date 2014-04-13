using UnityEngine;
using System.Collections;

/// <summary>
/// Sends player to jail
/// </summary>
[System.Serializable]
public class GoToObjectAction : BaseAction {

	/// <summary>
	/// Finds the object with the given name and goes to it.
	/// </summary>
	public string objectName = "jail";

	/// <summary>
	/// Execute the action.
	/// </summary>
	/// <param name="obj">The object executing the action.</param>
	override public void Execute(GameObject obj, ActionData data = new ActionData()) {
		GameObject gotoObj = GameObject.Find("jail");
		obj.transform.position = gotoObj.transform.position;
	}
}
