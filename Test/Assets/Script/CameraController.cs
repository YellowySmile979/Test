using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float lookAhead = 3;
    public float smoothing = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.position.x + lookAhead * Mathf.Sign(target.localScale.x),
                target.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothing);

    }
}
