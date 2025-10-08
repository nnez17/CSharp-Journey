﻿using System.Reflection;
using Sharprompt;

class Program
{
  static void Main()
  {
    // Get all public static methods that starts with '_'
    var allMethods = Assembly.GetExecutingAssembly()
      .GetTypes()
      .Where(t => t.IsClass && t.IsPublic)
      .SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Static)
        .Where(m => m.Name.StartsWith("Praktik") | m.Name.StartsWith("Tugas") | m.Name.StartsWith("Latihan") | m.Name.StartsWith("Operator") | m.Name.StartsWith("Contoh")))
      .ToList();

    // Get all unique namespaces
    var namespaces = allMethods
      .Select(m => m.DeclaringType?.Namespace)
      .Distinct()
      .Where(ns => ns != null)
      .Reverse()
      .Cast<string>()
      .ToList();

    // First prompt selecting namespace
    var selectedNamespace = Prompt.Select("Choose a namespace", namespaces);

    // Filter method of selected namespace
    var methodsInNamespace = allMethods
      .Where(m => m.DeclaringType?.Namespace == selectedNamespace)
      .ToList();

    // Format to Class.Method
    var options = methodsInNamespace
      .Select(m => $"{m.DeclaringType?.Name}.{m.Name}")
      .ToList();

    // Second pormpt selecting Class.Method
    var selectedMethod = Prompt.Select($"Choose a project from {selectedNamespace}", options);

    Console.WriteLine();

    // Separate class and method;
    var parts = selectedMethod.Split('.');
    var className = parts[0];
    var methodName = parts[1];

    // Find the method
    var method = methodsInNamespace
      .FirstOrDefault(m =>
        m.DeclaringType?.Name == className &&
        m.Name == methodName);

    // Execute
    method?.Invoke(null, null);
  }
}