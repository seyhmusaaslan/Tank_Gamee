using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Kamera, hedefi takip eden bir bile�en olarak kullan�l�r
public class CameraFollow : MonoBehaviour
{
    // Takip edilecek nesne
    public Transform target;

    // Kamera takibinin yumu�akl���n� kontrol eden bir de�i�ken
    public float smoothSpeed = 0.125f;

    // Kamera ile hedef aras�ndaki ba�lang�� pozisyonu fark�
    public Vector3 offset;

    // Her sabit zaman aral���nda �a�r�l�r
    void FixedUpdate()
    {
        // Hedefin yeni pozisyonunu hesapla
        Vector3 desiredPosition = target.position + offset;

        // Yumu�at�lm�� bir pozisyonu hesapla
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Kameray� yeni pozisyona y�nlendir
        transform.position = smoothedPosition;

        // Kameray� hedefe do�ru �evir
        transform.LookAt(target);
    }
}

