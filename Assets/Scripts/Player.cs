using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform _transform;
    public float _speed;

    void Start()
    {
    }

    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");
    }
}
