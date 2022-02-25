public static class PianoKeyExtensions
{
    public static bool IsSharp(this PianoKey key)
    {
        switch (key)
        {
            case PianoKey.CSharp:
            case PianoKey.DSharp:
            case PianoKey.FSharp:
            case PianoKey.GSharp:
            case PianoKey.ASharp:
                return true;
            default:
                return false;
        }
    }
}
