using UnityEngine;
using System.Collections;

/// <summary>
/// Handles a set of conversations.
/// </summary>
public class ConversationSet : MonoBehaviour {

	/// <summary>
	/// Array of conversations for a game object
	/// </summary>
	public Conversation[] conversations;

	/// <summary>
	/// The index of the active conversation.
	/// </summary>
	public int activeConversationIndex = 0;

	/// <summary>
	/// Gets the active conversation.
	/// </summary>
	/// <returns>The active conversation.</returns>
	public Conversation GetActiveConversation() {
		if (activeConversationIndex >= conversations.Length) {
			Debug.LogError("ConversationSet invalid index=" + activeConversationIndex + ", length=" + conversations.Length);
			return conversations[0];
		}
		return conversations[activeConversationIndex];
	}

	/// <summary>
	/// Updates GUI for this conversation when it is active.
	/// Returns index of the response chosen or -1 if none chosen yet.
	/// </summary>
	public int UpdateGUI() {
		Conversation conversation = GetActiveConversation();
		return conversation.UpdateGUI();
	}
}
