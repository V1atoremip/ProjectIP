using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public FireballScript fireballPrefab;
    public Transform fireballSoureceTransform;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, fireballSoureceTransform.position, fireballSoureceTransform.rotation);
        }
    }
}
