using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    public GameObject bulletPrefab; // Mermi prefabý
    public Transform firePoint; // Ateþ noktasý
    public float rotationSpeed = 30f; // Taret dönme hýzý
    public float fireRate = 1f; // Ateþ hýzý

    private float nextFireTime = 0f;

    void Update()
    {
        // Kullanýcý giriþini al
        float rotationInput = Input.GetAxis("TurretRotation");

        // Turret'i döndür
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationAmount);

        // Ateþ etme kontrolü
        if (Input.GetButtonDown("Fire1") && Time.time > nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        // Mermi prefabýný kullanarak mermiyi oluþtur ve ateþ et
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = bullet.transform.forward * 20f; // Mermi hýzý
    }
}

