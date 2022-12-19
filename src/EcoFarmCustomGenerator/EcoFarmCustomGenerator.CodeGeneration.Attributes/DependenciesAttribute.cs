using System;
using System.Collections.Generic;

namespace EcoFarmCustomGenerator.CodeGeneration.Attributes
{
	[AttributeUsage(AttributeTargets.Class)]
	public class DependenciesAttribute : Attribute
	{
		private readonly Type[] _dependencies;
		public List<Type> Dependencies => new List<Type>(_dependencies);

		public DependenciesAttribute(params Type[] dependencies) => _dependencies = dependencies;
	}
}