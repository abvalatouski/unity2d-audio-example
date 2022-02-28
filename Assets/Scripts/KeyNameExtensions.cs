namespace Piano
{
    public static class KeyNameExtensions
    {
        public static bool IsSharp(this KeyName key)
        {
            switch (key)
            {
                case KeyName.CSharp:
                case KeyName.DSharp:
                case KeyName.FSharp:
                case KeyName.GSharp:
                case KeyName.ASharp:
                    return true;
                default:
                    return false;
            }
        }
    }
}
