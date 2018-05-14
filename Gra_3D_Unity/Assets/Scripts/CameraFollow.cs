using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public Transform target;            // Obiekt za którym podąża kamera
    public float smoothing = 5f;        // Prędkość kamery

    Vector3 offset;                     // Pozycja początkowa obiektu

    void Start()
    {
        // Ustaw różnicę pomiędzy kamerą, a obiektem
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        //Stwórz pozycje za jaką ma podążać kamera
        Vector3 targetCamPos = target.position + offset;

        // Delikatnie przemieść kamerę
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}