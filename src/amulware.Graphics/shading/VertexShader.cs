﻿using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace amulware.Graphics
{
    /// <summary>
    /// This class represents a GLSL vertex shader.
    /// </summary>
    sealed public class VertexShader : Shader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VertexShader"/> class.
        /// </summary>
        /// <param name="filename">The file to load the shader from.</param>
        public VertexShader(string filename) : base(ShaderType.VertexShader, filename) { }
    }
}