namespace Radzen;

/// <summary>
/// Specifies the filter case sensitivity of a component.
/// </summary>
public enum FilterCaseSensitivity
{
    /// <summary>
    /// Relies on the underlying provider (LINQ to Objects, Entity Framework etc.) to handle case sensitivity. LINQ to Objects is case sensitive. Entity Framework relies on the database collection settings.
    /// </summary>
    Default,

    /// <summary>
    /// Filters are case insensitive regardless of the underlying provider.
    /// </summary>
    CaseInsensitive
}
/// <summary>
/// Specifies the filter Diacritics sensitivity of a component.
/// </summary>
public enum FilterDiacriticsSensitivity
{
    /// <summary>
    /// Relies on the underlying provider (LINQ to Objects, Entity Framework etc.) to handle Diacritics sensitivity. LINQ to Objects is Diacritics sensitive. Entity Framework relies on the database collection settings.
    /// </summary>
    Default,

    /// <summary>
    /// Filters are Diacritics insensitive regardless of the underlying provider.
    /// </summary>
    DiacriticsInsensitive
}
/// <summary>
/// Specifies the filter Symbols sensitivity of a component.
/// </summary>
public enum FilterSymbolsSensitivity
{
    /// <summary>
    /// Relies on the underlying provider (LINQ to Objects, Entity Framework etc.) to handle Symbols sensitivity. LINQ to Objects is Symbols sensitive. Entity Framework relies on the database collection settings.
    /// </summary>
    Default,

    /// <summary>
    /// Filters are Symbols insensitive regardless of the underlying provider.
    /// </summary>
    SymbolInsensitive
}


