using System;

using R5T.T0131;


namespace R5T.Z0064.Z002
{
    /// <summary>
    /// Contains strange, weird, but logical namespace names.
    /// For example, what is the name of the namespace that contains all namespaces (the empty string "").
    /// </summary>
    [ValuesMarker]
    public partial interface INamespaceNames : IValuesMarker
    {
        /// <summary>
        /// "": ALL namespaces are contained within the namespace with this name.
        /// As in, all of "System", "global::System", "R5T", extern alias DependencyX -> "DependencyX::System" are contained within "".
        /// </summary>
        /// <remarks>
        /// Useful in testing namespace accessibility logic.
        /// </remarks>
        public const string AllNamespaces_Constant = "";

        /// <inheritdoc cref="AllNamespaces_Constant"/>
        public string AllNamespaces => AllNamespaces_Constant;
    
        /// <summary>
        /// &lt;null&gt;: No namespaces are contained within the namespace with this name.
        /// No matter was namespace name you can dream up, the result of any ContainsNamespace(parentNamespaceName, childNamespaceName) implementation will be false if the parent has this namespace name.
        /// </summary>
        /// <remarks>
        /// Useful in testing namespace accessibility logic.
        /// </remarks>
        public const string NoNamespaces_Constant = null;

        /// <inheritdoc cref="NoNamespaces_Constant"/>
        public string NoNamespaces => NoNamespaces_Constant;
    }
}
