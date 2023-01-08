using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceQueue : MonoBehaviour {

	public AudioSource AS;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!AS.isPlaying) {

			if (Main.Data.QueuedVoiceLine != null) {
				Main.Data.CurrentVoiceLine = Instantiate (Main.Data.QueuedVoiceLine);
				Main.Data.QueuedVoiceLine = null;
			}

			Destroy (gameObject);

		}

	}
}
