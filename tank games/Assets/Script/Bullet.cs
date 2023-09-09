using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mermi s�n�f�, mermilerin davran��lar�n� y�netir
public class Bullet : MonoBehaviour
{
    // Mermi h�z� (birim/s)
    public float speed = 10f; // Mermi h�z�

    // Her �er�eve g�ncellendi�inde �a�r�l�r
    void Update()
    {
        // Mermiyi ileri do�ru hareket ettir
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // �arp��ma alg�land���nda �a�r�l�r
    void OnCollisionEnter(Collision collision)
    {
        // �arp��an nesne "Cube" etiketine sahipse
        if (collision.gameObject.CompareTag("Cube"))
        {
            // �arp��an nesneyi yok et
            Destroy(collision.gameObject);
        }

        // Mermiyi yok et
        Destroy(gameObject);
    }
}
