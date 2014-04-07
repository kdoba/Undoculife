using UnityEngine;
using System.Collections;

/// <summary>
/// Action to move towards a location (move in x or y depending on which is farther).
/// </summary>
[System.Serializable]
public class MoveToAction : BaseAction {

	/// <summary>
	/// The speed/force to apply to move.
	/// </summary>
	public float speed = 10;

	/// <summary>
	/// Execute the action.
	/// </summary>
	/// <param name="obj">The object executing the action.</param>
	override public void Execute(GameObject obj, ActionData data = new ActionData()) {
		float xDiff = data.pos.x - obj.transform.position.x;
		float yDiff = data.pos.y - obj.transform.position.y;

		if (xDiff != 0 && yDiff != 0) {
			if (Mathf.Abs(xDiff) > Mathf.Abs(yDiff)) {
				if (rigidbody2D != null) {
					float sign = xDiff >= 0 ? 
						1 : -1;
					rigidbody2D.AddForce(new Vector2(sign * speed, 0));
				} 
			} else {
				if (rigidbody2D != null) {
					float sign = yDiff >= 0 ? 
						1 : -1;
					rigidbody2D.AddForce(new Vector2(0, sign * speed));
				} 
			}
		}
	}
}
