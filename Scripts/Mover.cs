using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private Transform[] _waypoints;

    private int _currentPoint;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentPoint].position, _speedMove * Time.deltaTime);

        if (transform.position == _waypoints[_currentPoint].position)
            SelectNextPlace();
    }

    private void SelectNextPlace()
    {
        _currentPoint = ++_currentPoint % _waypoints.Length;

        transform.forward = _waypoints[_currentPoint].position - transform.position;
    }
}