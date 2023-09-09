using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mermi sýnýfý, mermilerin davranýþlarýný yönetir
public class Bullet : MonoBehaviour
{
    // Mermi hýzý (birim/s)
    public float speed = 10f; // Mermi hýzý

    // Her çerçeve güncellendiðinde çaðrýlýr
    void Update()
    {
        // Mermiyi ileri doðru hareket ettir
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // Çarpýþma algýlandýðýnda çaðrýlýr
    void OnCollisionEnter(Collision collision)
    {
        // Çarpýþan nesne "Cube" etiketine sahipse
        if (collision.gameObject.CompareTag("Cube"))
        {
            // Çarpýþan nesneyi yok et
            Destroy(collision.gameObject);
        }

        // Mermiyi yok et
        Destroy(gameObject);
    }
}
