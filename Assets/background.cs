using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public Transform character; // Referensi ke transform karakter
    public Vector3 offset; // Offset untuk posisi latar belakang relatif terhadap karakter

    void Start()
    {
        if (character == null)
        {
            Debug.LogError("Character Transform is not assigned!");
        }
    }

    void Update()
    {
        if (character != null)
        {
            // Update posisi latar belakang untuk mengikuti karakter
            Vector3 newPosition = new Vector3(character.position.x + offset.x, character.position.y + offset.y, transform.position.z);
            transform.position = newPosition;

            Debug.Log("Background Position: " + transform.position);
            Debug.Log("Character Position: " + character.position);
        }
    }
}
