using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Rainbow_braces
{
    /// <summary>
    /// Classification type definition export for Rainbow
    /// </summary>
    internal static class RainbowClassificationDefinition
    {
        // This disables "The field is never used" compiler's warning. Justification: the field is used by MEF.
#pragma warning disable 169

        /// <summary>
        /// Defines the "Rainbow" classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Rainbow")]
        private static ClassificationTypeDefinition typeDefinition;

#pragma warning restore 169
    }
}
