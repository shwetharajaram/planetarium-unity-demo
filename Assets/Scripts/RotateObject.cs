using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationRate; // y-rotation in angles
    private bool rotateProjector = false;

    private void Start() {
        
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.R)) {
            Debug.Log("R pressed");
            rotateProjector = !rotateProjector;
        }

        if (rotateProjector) {
            transform.Rotate(0, rotationRate, 0, Space.Self);
        }
    }

    public void ToggleRotate() {
        rotateProjector = !rotateProjector;
    }
}
