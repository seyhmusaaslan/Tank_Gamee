using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    public GameObject bulletPrefab; // Mermi prefab�
    public Transform firePoint; // Ate� noktas�
    public float rotationSpeed = 30f; // Taret d�nme h�z�
    public float fireRate = 1f; // Ate� h�z�

    private float nextFireTime = 0f;

    void Update()
    {
        // Kullan�c� giri�ini al
        float rotationInput = Input.GetAxis("TurretRotation");

        // Turret'i d�nd�r
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationAmount);

        // Ate� etme kontrol�
        if (Input.GetButtonDown("Fire1") && Time.time > nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        // Mermi prefab�n� kullanarak mermiyi olu�tur ve ate� et
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = bullet.transform.forward * 20f; // Mermi h�z�
    }
}

