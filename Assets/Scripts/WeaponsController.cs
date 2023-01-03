using UnityEngine;

public class WeaponsController : MonoBehaviour
{
    [SerializeField] private GameObject[] _weapons;

    private int _currentIndex = 0;

    private void Start()
    {
        UpdateWeapons();
    }

    private void Update()
    {
        CheckWeapons();
    }

  

    private void CheckWeapons()
    {
        if (_currentIndex >= _weapons.Length)
        {
            _currentIndex = 0;
            UpdateWeapons();
        }

        if (_currentIndex < 0)
        {
            _currentIndex = _weapons.Length - 1;
            UpdateWeapons();
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        { 
            _currentIndex++;
            UpdateWeapons();
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        { 
            _currentIndex--;
            UpdateWeapons();
        }
    }

    private void UpdateWeapons()
    {
        for (int i = 0; i < _weapons.Length; i++)
        {
            if (i == _currentIndex)
            {
                _weapons[i].SetActive(true);
            }
            else
            {
                _weapons[i].SetActive(false);
            }
        }
    }
}
