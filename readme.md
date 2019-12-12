# .Net Type Forwarding Example

`TypeForwardingTest` application references `BlackClass` and `RedClass` from `MyLibrary.dll`. In the next version, the library is split into two parts:  `BlackLibrary.dll` and `RedLibrary.dll`: those are in the "v2" folder.

However, we can still keep existing callers compatible by creating a shim version of `Library.dll` that forwards `BlackClass` and `RedClass` to the new assemblies.

Run `make_v2.bat` to copy v2 binaries to the `bin` folder, and observe that the original `TypeForwardingTest.exe` runs just fine, invoking new versions of the classes from new assemblies.

Note that `BlackLibrary.dll` and `RedLibrary.dll`  are signed with a different public key, and it does not cause any issues. `MyLibrary.dll`, however, has to be signed with the same key in all versions, or binary compatibility will be broken.

See also: 
- [Blog entry about the subject on ikriv.com](https://ikriv.com/blog/?p=4603 "Blog entry about the subject on ikriv.com")
- [Youtube video on how type forwarding is used in .Net Standard](https://youtu.be/vg6nR7hS2lI "Youtube video on how type forwarding is used in .Net Standard")