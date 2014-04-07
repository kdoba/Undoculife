using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// A script for a player to start conversations with other npcs.
/// </summary>
public class ConversationStarter : MonoBehaviour {

	/// <summary>
	/// The name of the event to raise on collision.
	/// </summary>
	public string eventName = "OnConversation";

	/// <summary>
	/// Optional user interface prefab for dialog.
	/// </summary>
	public GameObject uiPrefab = null;

	/// <summary>
	/// The active conversation.
	/// </summary>
	private Conversation activeConversation;

	/// <summary>
	/// The current ui shown, if any.
	/// </summary>
	private GameObject _uiShown = null;

	/// <summary>
	/// The current array of _buttons.
	/// </summary>
	private Button[] _buttons = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	/// <summary>
	/// Updates gui.
	/// </summary>
	void OnGUI() {
		if (activeConversation != null) {
			if (_uiShown == null) {
				int responseIndex = activeConversation.UpdateGUI();
				if (responseIndex >= 0) {
					Conversation oldConversation = activeConversation;
					activeConversation = null;

					if (responseIndex < oldConversation.responses.Length) {
						oldConversation.responses[responseIndex].Execute(gameObject);
					}
				}
			}
		}
	}

	/// <summary>
	/// Sends a conversation message on collision.
	/// </summary>
	void OnCollisionEnter2D(Collision2D collision) {
		StartConversation(collision.collider.gameObject);
	}

	/// <summary>
	/// Starts the conversation with another game object.
	/// </summary>
	/// <param name="obj">Object.</param>
	public void StartConversation(GameObject obj) {
		ConversationSet conversationSet = obj.GetComponent<ConversationSet>();
		if (conversationSet != null) {
			activeConversation = conversationSet.GetActiveConversation();
		}
		obj.SendMessage(eventName, SendMessageOptions.DontRequireReceiver);

		if (uiPrefab != null) {
			// TODO: finish this
			_uiShown = Instantiate(uiPrefab) as GameObject;
			_buttons = _uiShown.GetComponentsInChildren<Button>();
			for (int i = 0; i < _buttons.Length; ++i) {
//				Button.ButtonClickedEvent ev = new Button.ButtonClickedEvent();
//				ev.AddListener( 
//				_buttons[i].onClick += OnResponseClick;
			}
			Button button;
		}
	}

	/// <summary>
	/// Called on a response click.
	/// </summary>
	private void OnResponseClick() {
		int i = 0;
		if (activeConversation != null) {
			// TODO: finish this
//			activeConversation.responses[
			foreach (Button button in _buttons) {
//				button.onClick -= OnResponseClick;
			}
			activeConversation = null;
		}
	}
}
