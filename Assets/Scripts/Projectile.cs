using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody _rigidbody;
    public float _force = 3000.0f;
    private Vector3 _direction;

    void Start()
    {
        _rigidbody.AddForce(_direction * _force);
        Destroy(gameObject, 5.0f);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }
}


