using UnityEngine;
using System.Collections;

/// <summary>
/// Action to start a conversation with a game object.
/// </summary>
[System.Serializable]
public class ConversationAction : BaseAction {

	/// <summary>
	/// Game object to have a conversation with.
	/// If null, uses the current game object.
	/// </summary>
	public GameObject conversationObject;

	/// <summary>
	/// The index of the conversation to activate. -1 to not set new active index.
	/// </summary>
	public int conversationIndex = -1;

	/// <summary>
	/// If true, starts the conversation immediately.
	/// </summary>
	public bool startNow = true;

	/// <summary>
	/// Execute the action.
	/// </summary>
	/// <param name="obj">The object executing the action.</param>
	override public void Execute(GameObject obj) {
		ConversationStarter starter = obj.GetComponent<ConversationStarter>();
		GameObject convObject = conversationObject == null ? 
			gameObject : conversationObject;
		ConversationSet conversation = convObject.GetComponent<ConversationSet>();

		if (starter != null && conversation != null) {
			if (conversationIndex != -1) {
				conversation.activeConversationIndex = conversationIndex;
			}
			if (startNow) {
				starter.StartConversation(convObject);
			}
		}
	}
}
