﻿using System;

namespace Microsoft.Dnx.Runtime.Compilation
{
    /// <summary>
    /// Provides an interface to the Compilation Engine used to compile and load projects
    /// </summary>
    public interface ICompilationEngineFactory
    {
        /// <summary>
        /// Creates a new <see cref="ICompilationEngine"/> for the provided runtime graph.
        /// </summary>
        /// <returns></returns>
        ICompilationEngine CreateEngine(CompilationEngineContext context);
    }
}