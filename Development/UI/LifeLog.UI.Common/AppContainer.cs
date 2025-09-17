using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using LifeLog.Base.Infrastructure.Interfaces;
using Autofac;

namespace LifeLog.UI.Common
{
	public class AppContainer : IDisposable
	{
		//PRPERTY
		public IEngineForm EngineForm { get; set; }

		//PRIVATE
		private readonly IContainer container;
		private readonly ILifetimeScope scope;

		/// <summary>
		/// Construtor
		/// </summary>
		/// <param name="module"></param>
		public AppContainer(string module)
		{
			ContainerBuilder containerBuilder = new ContainerBuilder();

			DependicyResolver<IEngineForm>(containerBuilder, module);

			container = containerBuilder.Build();

			scope = container.BeginLifetimeScope();

			EngineForm = container.Resolve<IEngineForm>();
		}

		#region FUNCTION

		/// <summary>
		/// Depends the resolver for the specified type.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="builder"></param>
		/// <param name="dll"></param>
		private void DependicyResolver<T>(ContainerBuilder builder, string dll)
		{
			RegisterDep<T>(GetEnumerableTypes<T>(dll), builder);
		}

		/// <summary>
		/// Registers the dependency in the container.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="types"></param>
		/// <param name="builder"></param>
		private void RegisterDep<T>(IEnumerable<System.Type> types, ContainerBuilder builder)
		{
			foreach (Type t in types)
			{
				builder.RegisterType(t).As<T>();
			}
		}

		/// <summary>
		/// Gets the enumerable types from the specified assembly.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="NomeDll"></param>
		/// <returns></returns>
		private IEnumerable<Type> GetEnumerableTypes<T>(string NomeDll)
		{
			IEnumerable<Type> ret = Directory.EnumerateFiles(Directory.GetCurrentDirectory())
				.Where(x => x.Contains(NomeDll) && x.EndsWith(NomeDll + ".dll"))
				.Select(x => Assembly.LoadFrom(x))
				.SelectMany(x => x.GetTypes()
					.Where(t => typeof(T).IsAssignableFrom(t) && t.IsClass));

			return ret;
		}

		/// <summary>
		/// Disposes the container and scope.
		/// </summary>
		public void Dispose()
		{
			container?.Dispose();
			scope?.Dispose();
		}

		#endregion
	}
}
