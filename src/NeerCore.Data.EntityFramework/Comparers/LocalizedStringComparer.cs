using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace NeerCore.Data.EntityFramework.Comparers;

public sealed class LocalizedStringComparer : ValueComparer<LocalizedString>
{
    public LocalizedStringComparer() : base(
        equalsExpression: (a, b) => a.Equals(b),
        hashCodeExpression: s => s.GetHashCode()
    ) { }
}