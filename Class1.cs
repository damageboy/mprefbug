using System;

namespace mpref
{
    public class Class1
    {
      static Class1() {
        Mono.Posix.Syscall.readlink("/foo");
      }
    }
}
