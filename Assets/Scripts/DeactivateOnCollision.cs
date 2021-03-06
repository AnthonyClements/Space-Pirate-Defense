﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateOnCollision : MonoBehaviour {

    public List<string> colliders;
    private void OnTriggerEnter(Collider other)
    {
        if (colliders.Contains(other.tag))
        {
            gameObject.SetActive(false);
        }
    }
}
