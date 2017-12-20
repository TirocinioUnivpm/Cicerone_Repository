using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ScriptStartAudio : MonoBehaviour,ITrackableEventHandler{
        private TrackableBehaviour mTrackableBehaviour;
        public AudioSource audio;
        bool attivo;



        void Start()
        {
        attivo = true;
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED || attivo== false)
            {
                // Play audio when target is found
                audio.Play();
                attivo = true;


            }
            else
            {
                // Stop audio when target is lost
                audio.Stop();
            attivo = false;
            }
        }
    }
