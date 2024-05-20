using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform _transform;
    public float _speed;
    public float _horizontalSpeed;
    public float _verticalSpeed;

    void Start()
    {
    }

    void Update()
    {
        Vector3 newPosition = _transform.position;
        newPosition.z = newPosition.z + (_speed * Time.deltaTime);

        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");

        newPosition.x = newPosition.x + (xDirection * _horizontalSpeed * Time.deltaTime);
        newPosition.y = newPosition.y + (yDirection * _verticalSpeed * Time.deltaTime);

        _transform.position = newPosition;


    }
}


