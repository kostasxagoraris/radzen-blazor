using Microsoft.AspNetCore.Components;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Radzen;

/// <summary>
/// Contains extension methods for <see cref="ParameterView" />.
/// </summary>
public static class ParameterViewExtensions
{
    /// <summary>
    /// Checks if a parameter changed.
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    /// <param name="parameters">The parameters.</param>
    /// <param name="parameterName">Name of the parameter.</param>
    /// <param name="parameterValue">The parameter value.</param>
    /// <returns><c>true</c> if the parameter value has changed, <c>false</c> otherwise.</returns>
    public static bool DidParameterChange<T>(this ParameterView parameters, string parameterName, T parameterValue)
    {
        if (parameters.TryGetValue(parameterName, out T? value))
        {
            if (value is IEnumerable en1 && parameterValue is IEnumerable en2)
            {
                return en1.HasEnumerableChanged(en2);
            }
            else
            {
                return !EqualityComparer<T>.Default.Equals(value, parameterValue);
            }
        }

        return false;
    }
    /// <summary>
    /// Checkes If a list has valeus changes
    /// </summary>
    /// <param name="en1">The list to check</param>
    /// <param name="en2">The list to check against</param>
    /// <returns></returns>
    public static bool HasEnumerableChanged(this IEnumerable? en1, IEnumerable? en2)
    {
        if (en1 == null && en2 == null)
        {

            return false;
        }
        if (en1 == null && en2 != null || en1 != null && en2 == null)
        {
            return true;
        }
        var listOne = en1!.Cast<object>().ToList();
        var listTwo = en2!.Cast<object>().ToList();
        if (listOne.Count > listTwo.Count)
            return listOne.Except(listTwo).Any();
        else
            return listTwo.Except(listOne).Any();
    }
}

