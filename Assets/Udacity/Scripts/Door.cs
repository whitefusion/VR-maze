using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
    bool locked = true;

    /* Instantiate Sign Post after the door open */
    public GameObject mySignPost;

    public AudioClip[] doorSound;
    public AudioSource soundSource;

    public void DoorRaise() {
        // If the door is unlocked and it is not fully raised
        // Animate the door raising up
        Debug.Log("Door knocked ");
        if (locked)
        {
            soundSource.clip = doorSound[0];
            soundSource.Play();
        }
        if (!locked)
        {
            transform.Translate(0f, 20f * Time.deltaTime, 0f, Space.World);
            soundSource.clip = doorSound[1];
            soundSource.Play();
            Object.Instantiate(mySignPost, new Vector3(0.07f,23.073f,-5.33f), Quaternion.Euler(0,0,0));
            locked = true;
        }
           

    }

    public void Unlock()
    {
        // You'll need to set "locked" to true here
        // In my point of view, locked is false means unlocked;
        locked = false;
    }
}
