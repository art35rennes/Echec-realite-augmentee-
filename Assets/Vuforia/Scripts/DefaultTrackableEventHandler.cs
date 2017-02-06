/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {
        #region PRIVATE_MEMBER_VARIABLES
 
        private TrackableBehaviour mTrackableBehaviour;
        private Vector3 _rotation = Vector3.zero;

        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS

        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Enable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = true;
            }

            // Enable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = true;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
        }


        private void OnTrackingLost()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Disable rendering:
             foreach (Renderer component in rendererComponents)
             {
                 component.enabled = false;
             }

             // Disable colliders:
             foreach (Collider component in colliderComponents)
             {
                 component.enabled = false;
             }

            //Pivote objet lorsque tracking perdue
            _rotation.z = 0;
            _rotation.y = 0;
            _rotation.x = 0;

            //foreach (GameObject component in ObjetPerso){
            //    component.transform.Rotate(_rotation);
            //}

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
        }

        #endregion // PRIVATE_METHODS
    }
}

#region Exemple Code

/*

using UnityEngine;
using System.Collections;
 
[RequireComponent(typeof(MeshRenderer))]
 
public class rotateController : MonoBehaviour 
{
     
    #region ROTATE
    private float _sensitivity = 0.4f;
    private Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private Vector3 _rotation = Vector3.zero;
    private bool _isRotating;
     
 
    #endregion
 
    void Update()
    {
            if(_isRotating)
            {
                // offset
                _mouseOffset = (Input.mousePosition - _mouseReference);
 
                // apply rotation
                _rotation.z = -(_mouseOffset.x + _mouseOffset.y) * _sensitivity;
                 
                // rotate
                gameObject.transform.Rotate(_rotation);
                 
                // store new mouse position
                _mouseReference = Input.mousePosition;
            }
    }
 
     void OnMouseDown()
    {
            // rotating flag
            _isRotating = true;
             
            // store mouse position
            _mouseReference = Input.mousePosition;
    }
     
    void OnMouseUp()
    {
            // rotating flag
            _isRotating = false;
    }
          
     
*/

#endregion

