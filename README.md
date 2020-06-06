# Fortnite-Edit-Clicker
A small tool that'll edit faster than you could ever imagine.

I prioritized it's processor usage (both while just sitting in the background and while editing) and tried to optimize it as much as I could, which came at a cost as far as usage is concerned.

- The first is that the hotkey reacts to key up instead of key down event, which makes the edit initiating a bit slower. However, when the editing is already running, a hook for key down (and optionally also mouse down) event is registered and reacted to (and again turned off after the editing ends).

- The second is that the delay measurement (using Thread.Sleep) is not precise and practically can't get under ~15ms (depending on the machine). More precise timing could be used, but that would put a strain on the CPU with just a little payoff. A compromise is to set the system's timer resolution to higher when the editing starts, and set it backs when it stops, which should make Thread.Sleep a bit more consistent.
