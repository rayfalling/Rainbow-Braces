using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Operations;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;
using System.Windows.Media;

namespace Rainbow_braces {
    class HighlightBraces : TextMarkerTag {
        public HighlightBraces() : base("MarkerFormatDefinition/HighlightBracesFormatDefinition") {
        }
    }


    [Export(typeof(EditorFormatDefinition))]
    [Name("MarkerFormatDefinition/HighlightBracesFormatDefinition")]
    [UserVisible(true)]
    class HighlightBracesFormatDefinition : MarkerFormatDefinition {
        public HighlightBracesFormatDefinition() {
            this.BackgroundColor = Colors.LightBlue;
            this.ForegroundColor = Colors.DarkBlue;
            this.DisplayName = "Highlight Word";
            this.ZOrder = 5;
        }
    }
}