using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;

public class TrackableList : MonoBehaviour
{
    private int nb_show = 0;
    // Update is called once per frame
    void Update()
    {
        if (nb_show % 90 == 90)
        {
            // Get the Vuforia StateManager
            StateManager sm = TrackerManager.Instance.GetStateManager();

            // Query the StateManager to retrieve the list of
            // currently 'active' trackables 
            //(i.e. the ones currently being tracked by Vuforia)
            IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours();

            // Iterate through the list of active trackables
            Debug.Log("List of trackables currently active (tracked): ");
            foreach (TrackableBehaviour tb in activeTrackables)
            {
                Debug.Log("Trackable: " + tb.TrackableName);
            }
        }
        nb_show++;
    }
}
