using System.Collections;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    [SerializeField] private Bullet _prefab;
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
            var bullet = Instantiate(_prefab, transform.position + direction, Quaternion.identity);

            bullet.Initialize(direction, _speedBullet);

            yield return new WaitForSeconds(_delay);
        }
    }
}