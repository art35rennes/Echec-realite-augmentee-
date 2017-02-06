/*using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshRenderer))]

public class CustomRotation : MonoBehaviour {

    #region ROTATE
    private Vector3 _rotation = Vector3.zero;
    private bool _isRotating;


    #endregion

    void Update()
    {
        if (_isRotating)
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

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
*/