namespace ProvaCandidato.Models
{
    public static class ExtensionMethodBase
    {
        public static SelectList ToSelectList<TEnum>(this TEnum obj)
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {

        }
    }
}