using System;


namespace R5T.Z0064.Z002
{
    public class NamespaceNames : INamespaceNames
    {
        #region Infrastructure

        public static INamespaceNames Instance { get; } = new NamespaceNames();


        private NamespaceNames()
        {
        }

        #endregion
    }
}
