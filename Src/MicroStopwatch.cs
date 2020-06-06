namespace FortniteAutoclicker.Src
{
    class MicroStopwatch : System.Diagnostics.Stopwatch
    {
        readonly double _microSecPerTick = 1000000D / Frequency;
        public long ElapsedMicroseconds => (long)(ElapsedTicks * _microSecPerTick);
    }
}
