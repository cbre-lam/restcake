﻿namespace RestCake
{
	/// <summary>
	/// Applying this attribute on a method in a class with the [RestService] attribute will expose
	/// that method to access via the HTTP GET verb
	/// </summary>
	public class GetAttribute : VerbAttributeBase
	{ }
}
