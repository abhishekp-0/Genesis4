using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("Hit: " + collision.gameObject.name);
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("Wall"))
        {
            print("hit Wall");
            Destroy(gameObject);
        }
    }
}
