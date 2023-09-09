using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour
{
    public GameObject bulletPrefab;     // Mermi prefabý
    public Transform firePoint;         // Ateþ noktasý
    public float fireRate = 0.1f;       // Ateþ hýzý (saniyede kaç mermi atýlacak)

    private float nextFireTime = 0f;   // Bir sonraki ateþ zamaný

    private void Update()
    {
        // Ateþ tuþuna basýldýðýnda ateþ et
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Ateþ hýzýný kontrol et, eðer ateþ hýzý uygunsa ateþ et
        if (Time.time > nextFireTime)
        {
            // Mermi prefabýný kullanarak mermiyi oluþtur ve ateþ et
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = bullet.transform.forward * 20f; // Mermi hýzý

            // Bir sonraki ateþ zamanýný güncelle
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
}


