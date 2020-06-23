# Fortnite-Edit-Clicker
## A small tool that'll edit faster than you could ever imagine.

## Info
I prioritized it's processor usage (both while just sitting in the background and while editing) and tried to optimize it as much as I could - that's also why the hotkey reacts to key up instead of key down event, which makes the edit initiating a bit slower. However, when the editing is already running, a hook for key down (and optionally also mouse down) event is registered and reacted to (and again turned off after the editing ends).

## Power modes
Modes change the way the program measures delays.

### Normal mode
The delay is made by putting the current thread to sleep. This approach is the most imprecise one - the final delay is ~ [delay] + [5 - 15]ms, depending on the circumstances. It's however also the most efficient one.

### High mode
The delay is made by starting a Stopwatch and cycling in loop until the elapsed time >= delay. The final delay is [delay] + [1 - 5]ms, depending on the circumstances. This mode takes a lot of CPU resources.

### Ultra mode
The delay is made by starting a modified Stopwatch and cycling in a loop until the elapsed time >= delay. The stopwatch first establishes microseconds pass in one tick (1000000D / Frequency) and then produces the elapsed time in microseconds (Elapsed ticks * one tick microseconds). The accuracy can up to microseconds, depending on the circumstances.
