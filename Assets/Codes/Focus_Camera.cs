﻿using UnityEngine;
using System.Collections;
using Vuforia;

public class Focus_Camera : MonoBehaviour
{

 void Start() {    
  var vuforia = VuforiaARController.Instance;    
  vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);    
  vuforia.RegisterOnPauseCallback(OnPaused);
 }  

 private void OnVuforiaStarted() {    
  CameraDevice.Instance.SetFocusMode(
      CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
 }

 private void OnPaused(bool paused) {    
  if (!paused)
  {
       CameraDevice.Instance.SetFocusMode(
          CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);    
  }
 }
}