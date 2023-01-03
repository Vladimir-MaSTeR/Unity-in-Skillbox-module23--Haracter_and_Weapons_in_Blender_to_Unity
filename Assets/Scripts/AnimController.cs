using System;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private readonly Array keyCodes = Enum.GetValues(typeof(KeyCode));


    private void Update()
    {
        CheckAnim();

    }

    private void CheckAnim()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _animator.SetTrigger("OneAttack");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _animator.SetTrigger("TwoAttack");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _animator.SetTrigger("ThreeAttack");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _animator.SetTrigger("FourAttack");
        }
    }
}
