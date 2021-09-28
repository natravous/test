using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smooting = 5f;
    Vector3 offset;

    void Start()
    {
        // mendapatkan offset antara target dan camera
        offset = transform.position - target.position;
    }

    private void FixedUpdate()
    {
        // medapatkan posisi untuk kamera
        Vector3 targetCamPos = target.position + offset;

        // set posisi camera dengan smooting
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smooting * Time.deltaTime);
    }
}
