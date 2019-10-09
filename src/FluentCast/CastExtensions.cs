namespace Maestria.FluentCast
{
    public static class CastExtensions
    {
        public static T CastAs<T>(this object value) where T : class => value as T;
        public static T CastTo<T>(this object vale) => (T) vale;
    }
}