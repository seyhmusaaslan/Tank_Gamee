using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour
{
    public GameObject bulletPrefab;     // Mermi prefab�
    public Transform firePoint;         // Ate� noktas�
    public float fireRate = 0.1f;       // Ate� h�z� (saniyede ka� mermi at�lacak)

    private float nextFireTime = 0f;   // Bir sonraki ate� zaman�

    private void Update()
    {
        // Ate� tu�una bas�ld���nda ate� et
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Ate� h�z�n� kontrol et, e�er ate� h�z� uygunsa ate� et
        if (Time.time > nextFireTime)
        {
            // Mermi prefab�n� kullanarak mermiyi olu�tur ve ate� et
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = bullet.transform.forward * 20f; // Mermi h�z�

            // Bir sonraki ate� zaman�n� g�ncelle
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
}


