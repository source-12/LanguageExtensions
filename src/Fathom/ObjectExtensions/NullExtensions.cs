namespace Fathom.ObjectExtensions
{
    public static class NullExtensions
    {
        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }
    }    
}