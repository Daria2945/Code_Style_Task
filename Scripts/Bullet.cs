using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public void Initialize(Vector3 direction, float speed)
    {
        transform.up = direction;
        _rigidbody.velocity = direction * speed;
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
}