using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public Vector3 rotateRate;

    void Update() {
        transform.Rotate(rotateRate * Time.deltaTime);
    }
}