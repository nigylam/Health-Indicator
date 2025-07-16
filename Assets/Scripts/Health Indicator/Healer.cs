using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Healer : MonoBehaviour
{
    [SerializeField] private int _heal = 10;
    [SerializeField] private Health _health;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        Heal();
    }

    public void Heal()
    {
        _health.CanIncrease(_heal);
    }
}
