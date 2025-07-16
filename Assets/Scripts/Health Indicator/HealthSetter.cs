using UnityEngine;

[RequireComponent (typeof(Health))]
public class HealthSetter : MonoBehaviour
{
    [SerializeField] private int _start = 100;
    [SerializeField] private int _max = 100;

    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
        _health.Set(_start, _max);
    }
}
