﻿using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Score.score++;
    }
}