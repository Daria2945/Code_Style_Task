using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletShooter : MonoBehaviour
{
    [SerializeField] private Rigidbody _bulletPrefab;
    [SerializeField] private Transform _target;
    [SerializeField] private float _speedBullet;
    [SerializeField] private float _delay;

    private void Start()
    {
        StartCoroutine(Shot());
    }

    private IEnumerator Shot()
    {
        bool isWork = enabled;

        while (isWork)
        {
            Vector3 direction = (_target.position - transform.position).normalized;
            Rigidbody bullet = Instantiate(_bulletPrefab, transform.position + direction, Quaternion.identity);

            bullet.transform.up = direction;
            bullet.velocity = direction * _speedBullet;

            yield return new WaitForSeconds(_delay);
        }
    }
}