using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Damager : MonoBehaviour
{
    [SerializeField] private int _damage = 20;
    [SerializeField] private Health _health;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        TakeDamage();
    }

    public void TakeDamage()
    {
        _health.Decrease(_damage);
    }
}
