using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController _characterController;
    public Transform _transform;
    public float _speed = 20.0f;
    public float _rotationSpeed = 90.0f;
    public GameObject _explosionPrefab;
    public GameObject _projectilePrefab;

    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = Instantiate(_projectilePrefab);
            projectile.transform.position = _transform.position + (_transform.forward * 5.0f);
            projectile.GetComponent<Projectile>().SetDirection(_transform.forward);
        }

        float hAngle = xDirection * _rotationSpeed * Time.deltaTime;
        _transform.Rotate(Vector3.up, hAngle, Space.Self);

        float vAngle = yDirection * _rotationSpeed * Time.deltaTime;
        _transform.Rotate(Vector3.right, vAngle, Space.Self);

        Vector3 velocity = _transform.forward * _speed * Time.deltaTime;
        _characterController.Move(velocity);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        GameObject explosion = Instantiate(_explosionPrefab);
        explosion.transform.position = _transform.position;

        _transform.DetachChildren();
        Destroy(gameObject);
    }
}

