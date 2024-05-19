using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _timeForIncrease=0.5f;

    private TextMeshProUGUI _textMeshPro;
    private int _number = 0;

    private void Awake()
    {
        _textMeshPro=GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        StartCoroutine(StartIncrease());
    }

    private void OnDisable()
    {
        StopCoroutine(StartIncrease());
    }

    private IEnumerator StartIncrease()
    {
        while (enabled)
        {
            _number++;
            _textMeshPro.text = _number.ToString();
            yield return new WaitForSeconds(_timeForIncrease);
        }
    }

    public void ChangeEnable()
    {
        enabled = !enabled;
    }
}
