# Learning C#

The title says it all.

## Notes

* CLR - Common Language Runtime (kinda like a JVM)
  * IL (Intermediate code) - kinda like Java's bytecode
* Classes, namespaces and assemblies (.exes and .dlls)

* Variables and constants
  * If you want to use a name that collides with reserved words, use @ at the beginning of it. (e.g. @int)
  * camelCase, PascalCase, HugarionNotation (strFirstName)
  * Variables use camelCase
  * Constants use PascalCase
* Some primitive types: byte, short, int, long, float, double, decimal, char, bool.
  * 1.2f for floats
  * 1.2m for decimals
* String, Array, Enum and Class

* Over/Underflowing is not checked by default
  * Wrap it in `checked{}` to check it.
* `var` works kinda like `auto` in C++.

* Implicit, Explicit and non-compatible types conversion
  * `Convert` or `Parse` for non-compatible types conversions.