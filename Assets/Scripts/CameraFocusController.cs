using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraFocusController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var vufiria = VuforiaARController.Instance;
		vufiria.RegisterVuforiaStartedCallback(OnVuforiaStarted);
		vufiria.RegisterOnPauseCallback(OnPaused);
	}
	
	private void OnVuforiaStarted() {
		CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}
	private void OnPaused(bool paused) {
		if(!paused) {
			CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
