using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ExplodingFish inherits from AnimatedFish
public class ExplodingFish : AnimatedFish
{
    void Start()
    {
        pointValue = 2;

    }
    public override void destroyFish()
    {
        // Implementation to destroy the exploding fish, possibly with some animation
        Destroy(gameObject);

    }
}