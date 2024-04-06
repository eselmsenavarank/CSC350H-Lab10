using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// BurningFish inherits from AnimatedFish
public class BurningFish : AnimatedFish
{
    public Timer burnTimer;
    Ship ship;

    private void Start()
    {
        pointValue = 3;
        burnTimer = gameObject.AddComponent<Timer>();
        burnTimer.StartTimer(5); // Starts burning immediately upon spawning.
    }

    private void Update()
    {
        if (burnTimer.IsTimerRunning())
        {
            burnTimer.UpdateTimer();
        }
        else
        {
            destroyFish(); // Adjusted to directly destroy the fish when not collected in time.
        }
    }

    public override void destroyFish()
    {
        Destroy(gameObject);
    }
}
