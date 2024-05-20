using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    [SerializeField] private GameObject thisAnimator = null;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            thisAnimator.GetComponent<Animation>().Play();
            Destroy(gameObject);
        }
    }
}
