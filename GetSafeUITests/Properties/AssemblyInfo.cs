using System.Reflection;
using NUnit.Framework;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCopyright("Oleg Korobeinikov 2022")]

// Log4net
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

//NUnit
[assembly: Parallelizable(ParallelScope.All)]
[assembly: LevelOfParallelism(4)]

