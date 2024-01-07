using System;

using R5T.T0131;
using R5T.T0228;
using R5T.T0228.Extensions;


namespace R5T.Z0064.Z001
{
    [ValuesMarker]
    public partial interface INamespaceNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Z000.INamespaceNames _StringlyTyped => Z000.NamespaceNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z000.INamespaceNames.System"/>
        public INamespaceName System => _StringlyTyped.System.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.System_Collections_Generic"/>
        public INamespaceName System_Collections_Generic => _StringlyTyped.System_Collections_Generic.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.System_IO"/>
        public INamespaceName System_IO => _StringlyTyped.System_IO.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.System_Linq"/>
        public INamespaceName System_Linq => _StringlyTyped.System_Linq.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.System_Threading"/>
        public INamespaceName System_Threading => _StringlyTyped.System_Threading.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.System_Threading_Tasks"/>
        public INamespaceName System_Threading_Tasks => _StringlyTyped.System_Threading_Tasks.ToNamespaceName();
    }
}
