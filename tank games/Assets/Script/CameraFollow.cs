using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Kamera, hedefi takip eden bir bileþen olarak kullanýlýr
public class CameraFollow : MonoBehaviour
{
    // Takip edilecek nesne
    public Transform target;

    // Kamera takibinin yumuþaklýðýný kontrol eden bir deðiþken
    public float smoothSpeed = 0.125f;

    // Kamera ile hedef arasýndaki baþlangýç pozisyonu farký
    public Vector3 offset;

    // Her sabit zaman aralýðýnda çaðrýlýr
    void FixedUpdate()
    {
        // Hedefin yeni pozisyonunu hesapla
        Vector3 desiredPosition = target.position + offset;

        // Yumuþatýlmýþ bir pozisyonu hesapla
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Kamerayý yeni pozisyona yönlendir
        transform.position = smoothedPosition;

        // Kamerayý hedefe doðru çevir
        transform.LookAt(target);
    }
}

