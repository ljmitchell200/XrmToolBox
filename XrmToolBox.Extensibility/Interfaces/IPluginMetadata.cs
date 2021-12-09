﻿using System;

namespace XrmToolBox.Extensibility.Interfaces
{
    public interface IPluginMetadata
    {
        string BackgroundColor { get; }
        string BigImageBase64 { get; }
        string Description { get; }
        string Name { get; }
        string PrimaryFontColor { get; }
        string SecondaryFontColor { get; }
        string SmallImageBase64 { get; }

	    string Company { get; }
	    string PluginType { get; }
	    string Control { get; }
	    string AssemblyQualifiedName { get; }
	    string AssemblyFilename { get; }
	    string Version { get; }
	    Guid Id { get; }
	    string[] Interfaces { get; }
    }
}