using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float speed;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    private void LateUpdate()
    {
        target.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
        target.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }
}
