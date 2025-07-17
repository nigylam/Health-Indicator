using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Button))]
public abstract class StatAffector : MonoBehaviour
{
    [SerializeField] protected int Value = 10;
    [SerializeField] protected Health Health;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    public abstract void OnClick();
}
