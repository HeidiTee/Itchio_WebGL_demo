using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCheese { get; private set; }

    [SerializeField] private AudioSource collectionSoundEffect;


    public void CheeseCollected()
    {
        collectionSoundEffect.Play();
        NumberOfCheese++;
    }
    

    
}
