using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Transform target = null;
    [SerializeField] float speed = 1;

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        transform.LookAt(target.position);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
