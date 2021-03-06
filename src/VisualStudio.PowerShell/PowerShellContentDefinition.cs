﻿using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace VisualStudio.PowerShell
{
    public class PowerShellContentDefinition
    {
        [Export]
        [Name("PowerShell")]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        internal static ContentTypeDefinition PowerShellContentTypeDefinition;

        [Export]
        [FileExtension(".ps1")]
        [ContentType("PowerShell")]
        internal static FileExtensionToContentTypeDefinition PowerShellFileExtensionDefinition;
    }
}
